using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCG.AspNetCore.Common.Configuration;
using CCG.AspNetCore.Web;
using DataModel;
using Microsoft.EntityFrameworkCore;
using SimpleInjector;
using Admin.Config;

namespace Admin
{
    public class Startup
    {
        private readonly Container _container = new Container();
        private readonly ConfigurationBootstrapper _bootstrapper;
        public AppConfiguration AppConfiguration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _bootstrapper = new ConfigurationBootstrapper(_container);
            AppConfiguration = Configuration.GetSection("App").Get<AppConfiguration>();

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();

            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromSeconds(600);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddRazorPages();

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
                        .AddViewComponentActivation()
                        .AddPageModelActivation()
                        .AddTagHelperActivation()
                        ;

                    // Optionally, allow application components to depend on the non-generic
                    // ILogger (Microsoft.Extensions.Logging) or IStringLocalizer
                    // (Microsoft.Extensions.Localization) abstractions.
                    //options.AddLogging();
                    //options.AddLocalization();
                })
                .WithCqrs(AppDomain.CurrentDomain.GetAssemblies().Where(e => e.FullName.Contains("Business")).ToArray())
                ;

            services.AddHttpClient("api", c =>
            {
                c.BaseAddress = new Uri(AppConfiguration.ApiEndpoint);
            });
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

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
        private void InitializeContainer()
        {
            _container.Register(
                () => new DbContextOptionsBuilder<CctDbContext>()
                    .UseSqlServer(Configuration.GetConnectionString("CctDbContext"), options => options.EnableRetryOnFailure())
                    .Options, Lifestyle.Singleton);
            _container.Register<DbContext, CctDbContext>(Lifestyle.Scoped);
            _container.Register<CctDbContext>(Lifestyle.Scoped);

        }
    }
}