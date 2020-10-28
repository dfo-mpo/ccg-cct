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
    public class CurrentPositionModel : PageModel
    {
        private readonly JobCategoryService _jobcategoryService;
        [BindProperty(SupportsGet = true)]
        public JobCategory JobCategory { get; set; }

        [BindProperty(SupportsGet = true)]
        public int filter { get; set; }
        [BindProperty(SupportsGet = true)]
        public int id { get; set; }
        public  CurrentPositionModel(ILogger<CurrentPositionModel> logger, JobCategoryService jobcategoryService)
        {
            //_logger = logger;
            _jobcategoryService = jobcategoryService;
        }
        public async Task OnGetAsync(int id)
        {
            JobCategory = await _jobcategoryService.GetJobCategoryById(id);
        }
    }
}
