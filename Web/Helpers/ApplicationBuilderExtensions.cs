using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Helpers
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseCultureRoutingAlways(this IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                var culture = context.GetRouteValue("culture")?.ToString();
                var page = context.GetRouteValue("page")?.ToString();

                if (culture == null && page != null)
                {
                    context.Response.Redirect("/en"+page);
                }
                await next();
            });
            return app;
        }
    }
}
