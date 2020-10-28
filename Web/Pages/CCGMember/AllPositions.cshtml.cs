using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Microsoft.AspNetCore.Routing;

namespace Web.Pages.CCGMember
{
    public class AllPositionsModel : PageModel
    {
        //private readonly ILogger<AllPositionsModel> _logger;
        private readonly JobCategoryService _jobcategoryService;
        public JobCategory[] JobCategories { get; set; }   
        
        [BindProperty(SupportsGet = true)]
        public string filter { get; set; }
        public AllPositionsModel(ILogger<AllPositionsModel> logger, JobCategoryService jobcategoryService)
        {
            //_logger = logger;
            _jobcategoryService = jobcategoryService;
        }
        public async Task OnGetAsync()
        {
            JobCategories = await _jobcategoryService.GetJobCategories();
        }

    }
}