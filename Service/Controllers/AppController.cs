using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;

namespace Service.Controllers
{
    public class AppController : Controller
    {
        private readonly IHostingEnvironment _hostingEnv;
        private readonly ExampleIdentityConfiguration _exampleIdentityConfiguration;

        public AppController(IHostingEnvironment env, ExampleIdentityConfiguration exampleIdentityConfiguration)
        {
            _hostingEnv = env;
            _exampleIdentityConfiguration = exampleIdentityConfiguration;
        }

        [HttpGet]
        public IActionResult RedirectIndex()
        {
            if (Request.Path.StartsWithSegments("/api")) return NotFound();

            if (Request.Path.ToString().EndsWith("/config/identity"))
                return GetIdentityConfigJs();

            return new PhysicalFileResult(
                Path.Combine(_hostingEnv.WebRootPath, "index.html"),
                new MediaTypeHeaderValue("text/html")
            );
        }

        public ContentResult GetIdentityConfigJs()
        {
            var data = JsonConvert.SerializeObject(_exampleIdentityConfiguration);
            return Content("window.identityConfig = " + data, "application/javascript");
        }
    }
}
