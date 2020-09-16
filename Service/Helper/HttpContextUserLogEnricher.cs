using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Serilog.Enrichers.AspnetcoreHttpcontext;

namespace Service.Helper
{
    public static class HttpContextUserLogEnricher
    {
        public static HttpContextUserClaims AddUserClaims(IHttpContextAccessor ctx)
        {
            var context = ctx.HttpContext;
            if (context == null) return null;
            var user = context.User;

            var info = new HttpContextUserClaims
            {
                StandardHttpContext = AspnetcoreHttpcontextEnricher.StandardEnricher(ctx),
                UserClaims = (user?.Identity != null && user.Identity.IsAuthenticated) ? user.Claims.Select(a => new { a.Type, a.Value }).ToList() : null
            };

            return info;
        }

    }

    public class HttpContextUserClaims 
    {
        public object StandardHttpContext { get; set; }
        public object UserClaims { get; set; }
    }
}