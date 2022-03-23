using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Web.Config;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization.Routing;
using Web.Helpers;
using System.Linq;
using SmartBreadcrumbs.Extensions;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using Microsoft.AspNetCore.Routing;

namespace Web
{
    public class Startup
    {
        public AppConfiguration AppConfiguration { get; set; }
        public static RequestCulture DefaultRequestCulture = new RequestCulture("en");

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            AppConfiguration = Configuration.GetSection("App").Get<AppConfiguration>();

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddLocalization(opts => { opts.ResourcesPath = "Resources"; });

            services.Configure<RouteOptions>(options => options.ConstraintMap.Add("french", typeof(FrenchRouteConstraint)));

            services
                .AddRazorPages()
                .AddRazorPagesOptions(options =>
                {
                    options.Conventions.Add(new CultureTemplatePageRouteModelConvention());
                })
                .AddViewLocalization(
                    LanguageViewLocationExpanderFormat.Suffix,
                    opts =>
                    {
                        opts.ResourcesPath = "Resources";

                    });

            services.AddBreadcrumbs(GetType().Assembly, options =>
            {
                // Testing
                options.DontLookForDefaultNode = true;
                options.ResourceType = typeof(Resx.BreadcrumbResources);
            });

            services.AddHttpClient("api", c =>
            {
                c.BaseAddress = new Uri(AppConfiguration.ApiEndpoint);
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            
            var types = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(p =>  typeof(Web.Data.IDataService).IsAssignableFrom(p) && !p.IsInterface && !p.IsAbstract);

            foreach (var type in types)
            {
                services.AddSingleton(type);
            }

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthorization();

            var supportedCultures = new List<CultureInfo> { new CultureInfo("en"), new CultureInfo("fr") };
            var requestLocalizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = DefaultRequestCulture,
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            };
            requestLocalizationOptions.RequestCultureProviders.Insert(0, new RouteDataRequestCultureProvider { Options = requestLocalizationOptions });
            app.UseRequestLocalization(requestLocalizationOptions);

            app.UseCultureRoutingAlways();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
            });
        }
    }
}
