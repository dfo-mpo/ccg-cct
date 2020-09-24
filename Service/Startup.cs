using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using CCG.AspNetCore.Business.Commands.Auth;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using CCG.AspNetCore.Common.Configuration;
using CCG.AspNetCore.Web;
using CCG.AspNetCore.Web.Authorization;
using Core;
using DataModel;
using FluentValidation;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using SimpleInjector;

namespace Service
{
    public class Startup
    {
        private readonly Container _container = new Container();
        private readonly EmailConfiguration _emailConfig;
        private readonly ApplicationConfiguration _appConfig;
        private readonly ExampleIdentityConfiguration _identityConfig;
        private readonly ConfigurationBootstrapper _bootstrapper;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _emailConfig = Configuration.GetSection("Email").Get<EmailConfiguration>();
            _appConfig = Configuration.GetSection("Application").Get<ApplicationConfiguration>();
            _identityConfig = Configuration.GetSection("IdentityProvider").Get<ExampleIdentityConfiguration>();
            _bootstrapper = new ConfigurationBootstrapper(_container);
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            ValidatorOptions.Global.LanguageManager = new LocalizedLanguageManager();


            services
                .AddControllers()
                .AddNewtonsoftJson(options => options.SerializerSettings.DateTimeZoneHandling  = DateTimeZoneHandling.Utc)
                .ConfigureApiBehaviorOptions(options =>
                {
                    options.SuppressConsumesConstraintForFormFileParameters = true;
                    options.SuppressInferBindingSourcesForParameters = true;
                    options.SuppressModelStateInvalidFilter = true;
                    options.SuppressMapClientErrors = true;
                    options.ClientErrorMapping[StatusCodes.Status404NotFound].Link = "https://httpstatuses.com/404";
                });

            services
                .AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = _identityConfig.Authority;
                    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidAudiences = _identityConfig.ValidAudiences
                    };
                    options.RequireHttpsMetadata = false;
                    options.Events = new JwtBearerEvents
                    {
                        OnTokenValidated = async context =>
                        {
                            Serilog.Log.Information("sign in");

                            if (!(context.Principal.Identity is ClaimsIdentity identity))
                                throw new ArgumentNullException(nameof(context.Principal.Identity));

                            var commandSender = _container.GetInstance<ICommandSender>();

                            if (identity.HasClaim(e => e.Type == "aud" && e.Value == _identityConfig.ClientAudience))
                            {

                                // get user data from claims
                                var command = new AddNewUserAccountCommand()
                                {
                                    NameIdentifier = identity.FindFirst(ClaimTypes.NameIdentifier).Value,
                                    GivenName = identity.FindFirst(ClaimTypes.GivenName).Value,
                                    Surname = identity.FindFirst(ClaimTypes.Surname).Value,
                                    Email = identity.FindFirst(ClaimTypes.Email).Value,
                                };

                                // when valid, create user
                                if ((await commandSender.ValidateAsync(command)).IsValid)
                                {
                                    await commandSender.SendAsync(command);
                                }
                                Serilog.Log.Information($"signin for {_identityConfig.ClientAudience}");
                            }

                            if (identity.HasClaim(e => e.Type == "aud" && e.Value == _identityConfig.GisAudience))
                            {
                                Serilog.Log.Information($"signin for {_identityConfig.GisAudience}");
                            }
                        }
                    };
                });

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        .WithOrigins(_identityConfig.Client)
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
            });

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });

                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme()
                {
                    Type = SecuritySchemeType.OAuth2,

                    Flows = new OpenApiOAuthFlows
                    {
                        Implicit = new OpenApiOAuthFlow
                        {
                            AuthorizationUrl = new Uri($"{_identityConfig.Authority}/connect/authorize", UriKind.Absolute),
                            Scopes = new Dictionary<string, string>
                            {
                                { _identityConfig.ClientScope, _identityConfig.ClientScope },
                            }
                        }
                    }
                });
                
                options.OperationFilter<AuthorizeCheckOperationFilter>();

            });

            _bootstrapper
                .Initialize(services, options =>
                {
                    // AddAspNetCore() wraps web requests in a Simple Injector scope and
                    // allows request-scoped framework services to be resolved.
                    options.AddAspNetCore()

                        // Ensure activation of a specific framework type to be created by
                        // Simple Injector instead of the built-in configuration system.
                        // All calls are optional. You can enable what you need. For instance,
                        // ViewComponents, PageModels, and TagHelpers are not needed when you
                        // build a Web API.
                        .AddControllerActivation()
                        //.AddViewComponentActivation()
                        //.AddPageModelActivation()
                        //.AddTagHelperActivation()
                        ;

                    // Optionally, allow application components to depend on the non-generic
                    // ILogger (Microsoft.Extensions.Logging) or IStringLocalizer
                    // (Microsoft.Extensions.Localization) abstractions.
                    //options.AddLogging();
                    //options.AddLocalization();
                })
                .WithAuditing()
                .WithAuthorization<ExampleDbContext>()
                .WithCqrs(AppDomain.CurrentDomain.GetAssemblies().Where(e => e.FullName.Contains("Business")).ToArray())
                ;

            InitializeContainer();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            _bootstrapper.Finalize(app);
            _container.Verify();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app
                .UseSwagger()
                .UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("v1/swagger.json", "My API V1");
                    options.OAuthClientId(_identityConfig.ClientId);
                    options.OAuthAppName(_identityConfig.ClientId);
                });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("/index.html");
            });

        }

        private void InitializeContainer()
        {
            _container.Register(
                () => new DbContextOptionsBuilder<ExampleDbContext>()
                    .UseSqlServer(Configuration.GetConnectionString("ExampleDbContext")).Options, Lifestyle.Singleton);
            _container.Register<DbContext, ExampleDbContext>(Lifestyle.Scoped);
            _container.Register<ExampleDbContext>(Lifestyle.Scoped);
            _container.Register(() => _emailConfig, Lifestyle.Singleton);
            _container.Register(() => _appConfig, Lifestyle.Singleton);
            _container.Register<CcgAccountClientConfiguration>(() => _identityConfig, Lifestyle.Singleton);
            _container.Register<ExampleIdentityConfiguration>(() => _identityConfig, Lifestyle.Singleton);

        }

    }
}

