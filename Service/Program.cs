using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Enrichers.AspnetcoreHttpcontext;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;
using Service.Helper;

namespace Service
{
    public class Program
    {
        public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
            .AddEnvironmentVariables()
            .Build();

        public static int Main(string[] args)
        {
            Serilog.Debugging.SelfLog.Enable(msg => Debug.WriteLine(msg));

            try
            {
                Log.Information("Starting web host");
                BuildWebHost(args).Run();
                return 0;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseSerilog((provider, context, loggerConfiguration) =>
                {
                    var options = new ColumnOptions();
                    options.Store.Remove(StandardColumn.Properties);
                    options.Store.Add(StandardColumn.LogEvent);

                    loggerConfiguration
                        .ReadFrom.Configuration(Configuration)
                        .Enrich.WithAspnetcoreHttpcontext(provider)
                        .Enrich.FromLogContext()
                        .Enrich.WithAspnetcoreHttpcontext(provider, customMethod: HttpContextUserLogEnricher.AddUserClaims)
                        .WriteTo.Console(outputTemplate:"[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj} {NewLine}{HttpContext}")
                        .WriteTo.MSSqlServer(
                            connectionString: Configuration.GetConnectionString("ExampleDbContext"),
                            tableName: "EventLogs",
                            columnOptions: options,
                            autoCreateSqlTable: true
                        );

                })
                .Build();

    }
}
