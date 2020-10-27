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

namespace Web.Pages.Internal
{
    public class Current_PositionModel : PageModel
    {
        private readonly JobCategoryService _jobcategoryService;
        public JobCategory JobCategory { get; set; }

        [BindProperty(SupportsGet = true)]
        public int filter { get; set; }
        [BindProperty(SupportsGet = true)]
        public int id { get; set; }
        public  Current_PositionModel(ILogger<Current_PositionModel> logger, JobCategoryService jobcategoryService)
        {
            //_logger = logger;
            _jobcategoryService = jobcategoryService;
        }
        public async Task OnGetAsync()
        {
            JobCategory = await _jobcategoryService.GetJobCategoryById(id);
        }
    }
}
