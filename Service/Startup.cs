using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Audit.Core;
using CCG.AspNetCore.Business.Commands.Audits;
using CCG.AspNetCore.Business.Commands.Auth;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using CCG.AspNetCore.Common.Configuration;
using CCG.AspNetCore.Data.Audit;
using CCG.AspNetCore.Web;
using CCG.AspNetCore.Web.Authorization;
using Core;
using DataModel;
using FluentValidation;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using SimpleInjector;
using Swashbuckle.AspNetCore.Swagger;

namespace Service
{
    public class Startup
    {
        private readonly Container _container = new Container();
        private readonly EmailConfiguration _emailConfig;
        private readonly ApplicationConfiguration _appConfig;
        private readonly ExampleIdentityConfiguration _identityConfig;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            _emailConfig = Configuration.GetSection("Email").Get<EmailConfiguration>();
            _appConfig = Configuration.GetSection("Application").Get<ApplicationConfiguration>();
            _identityConfig = Configuration.GetSection("IdentityProvider").Get<ExampleIdentityConfiguration>();
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            ValidatorOptions.LanguageManager = new LocalizedLanguageManager();


            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
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
                options.SwaggerDoc("v1", new Info { Title = "API", Version = "v1" });

                options.AddSecurityDefinition("oauth2", new OAuth2Scheme
                {
                    Flow = "implicit",
                    AuthorizationUrl = $"{_identityConfig.Authority}/connect/authorize",
                    Scopes = new Dictionary<string, string> { { _identityConfig.ClientScope, _identityConfig.ClientScope } }
                });
                options.OperationFilter<AuthorizeCheckOperationFilter>();
            });

            StartupHelper.ConfigureServices(services, _container);

            Audit.Core.Configuration.Setup()
                .UseEntityFramework(_ => _
                    .AuditTypeMapper(t => typeof(AuditLog))
                    .AuditEntityAction<AuditLog>(async (ev, entry, entity) =>
                    {
                        var commandSender = _container.GetInstance<ICommandSender>();
                        await commandSender.SendAsync(new AddAuditLogCommand() { Entity = entity, Entry = entry });
                    })
                    .IgnoreMatchedProperties());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            ConfigureContainer(app);

            app.UseCors("CorsPolicy");
            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            _container.Verify();

            app
                .UseSwagger()
                .UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("v1/swagger.json", "My API V1");

                    options.OAuthClientId(_identityConfig.ClientId);

                    options.OAuthAppName(_identityConfig.ClientId);
                })
                .UseMvc(routes =>
                {
                    routes.MapRoute(
                        name: "default",
                        template: "{controller=Home}/{action=Index}/{id?}");

                    routes.MapSpaFallbackRoute(
                        name: "catch-all",
                        defaults: new { controller = "App", action = "RedirectIndex" });
                })
                .UseStaticFiles()
                ;


        }

        private void ConfigureContainer(IApplicationBuilder app)
        {
            _container.Register(() => new DbContextOptionsBuilder<ExampleDbContext>().UseSqlServer(Configuration.GetConnectionString("ExampleDbContext")).Options, Lifestyle.Singleton);
            _container.Register<DbContext, ExampleDbContext>(Lifestyle.Scoped);
            _container.Register<ExampleDbContext>(Lifestyle.Scoped);
            _container.Register(() => _emailConfig, Lifestyle.Singleton);
            _container.Register(() => _appConfig, Lifestyle.Singleton);
            _container.Register<CcgAccountClientConfiguration>(() => _identityConfig, Lifestyle.Singleton);
            _container.Register<ExampleIdentityConfiguration>(() => _identityConfig, Lifestyle.Singleton);
            var assembliesToScan = AppDomain.CurrentDomain.GetAssemblies().Where(e => e.FullName.Contains("Business")).ToArray();
            StartupHelper.Configure<ExampleDbContext>(app, _container, assembliesToScan);
        }
    }
}

