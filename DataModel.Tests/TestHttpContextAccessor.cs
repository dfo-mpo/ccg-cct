using System.Collections.Generic;
using System.Security.Claims;
using CCG.AspNetCore.Data.Auth.Model;
using Microsoft.AspNetCore.Http;

namespace DataModel.Tests
{
    public class TestHttpContextAccessor : IHttpContextAccessor
    {
        public TestHttpContextAccessor()
        {
            HttpContext = new DefaultHttpContext();
        }

        public HttpContext HttpContext { get; set; }

        public void SetUser(IEnumerable<Claim> claims) 
        {
            HttpContext.User = new ClaimsPrincipal(new ClaimsIdentity(claims, "Basic"));
            
        }

        public void SetUser(User user)
        {
            SetUser(new []
            {
                new Claim(ClaimTypes.NameIdentifier, user.NameIdentifier)
            });
        }
    }

}