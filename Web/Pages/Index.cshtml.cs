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
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ClassificationService _classificationService;
        
        public Classification[] Classifications;

        public IndexModel(ILogger<IndexModel> logger, ClassificationService classificationService)
        {
            _logger = logger;
            _classificationService = classificationService;
        }

        public async Task OnGet()
        {
            Classifications = await _classificationService.GetClassifications();
        }
    }
}
