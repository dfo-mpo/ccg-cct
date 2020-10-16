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
        private readonly ApplicationConfiguration _appConfig;
        private readonly ConfigurationBootstrapper _bootstrapper;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _appConfig = Configuration.GetSection("Application").Get<ApplicationConfiguration>();
            _bootstrapper = new ConfigurationBootstrapper(_container);
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            ValidatorOptions.Global.LanguageManager = new LocalizedLanguageManager();


            services
                .AddControllers()
                .AddNewtonsoftJson(options => options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc)
                .ConfigureApiBehaviorOptions(options =>
                {
                    options.SuppressConsumesConstraintForFormFileParameters = true;
                    options.SuppressInferBindingSourcesForParameters = true;
                    options.SuppressModelStateInvalidFilter = true;
                    options.SuppressMapClientErrors = true;
                    options.ClientErrorMapping[StatusCodes.Status404NotFound].Link = "https://httpstatuses.com/404";
                });


            //services.AddCors(options =>
            //{
            //    options.AddPolicy("CorsPolicy",
            //        builder => builder
            //            .WithOrigins(_identityConfig.Client)
            //            .AllowAnyMethod()
            //            .AllowAnyHeader()
            //            .AllowCredentials());
            //});

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });

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
                .WithCqrs(AppDomain.CurrentDomain.GetAssemblies().Where(e => e.FullName.Contains("Business")).ToArray())
                ;

            InitializeContainer();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            _bootstrapper.Finalize(app);
            _container.Verify();

            UpdateDatabase();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app
                .UseSwagger()
                .UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("v1/swagger.json", "My API V1");
                });

            app.UseHttpsRedirection();

            app.UseRouting();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                if (env.IsDevelopment())
                {
                    endpoints.MapFallbackToFile("/index.html");
                }
            });

        }

        private void UpdateDatabase()
        {
            var opts = _container.GetInstance<DbContextOptions<CctDbContext>>();
            var accessor = new HttpContextAccessor { HttpContext = new DefaultHttpContext() };
            using var db = new CctDbContext(opts, accessor);
            db.Database.Migrate();
        }

        private void InitializeContainer()
        {
            _container.Register(
                () => new DbContextOptionsBuilder<CctDbContext>()
                    .UseSqlServer(Configuration.GetConnectionString("CctDbContext")).Options, Lifestyle.Singleton);
                    //.UseSqlite(Configuration.GetConnectionString("CctDbContext")).Options, Lifestyle.Singleton);
            _container.Register<DbContext, CctDbContext>(Lifestyle.Scoped);
            _container.Register<CctDbContext>(Lifestyle.Scoped);
            _container.Register(() => _appConfig, Lifestyle.Singleton);

        }

    }
}

