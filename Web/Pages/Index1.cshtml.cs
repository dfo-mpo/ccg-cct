using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages
{
    public class IndexModel1 : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        

        public IndexModel1(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public Task OnGet()
        {
            return Task.CompletedTask;
        }
    }
}
