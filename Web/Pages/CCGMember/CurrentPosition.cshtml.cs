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
        private readonly JobGroupService _jobcategoryService;
        [BindProperty(SupportsGet = true)]
        public JobGroup JobCategory { get; set; }

        [BindProperty(SupportsGet = true)]
        public int filter { get; set; }
        [BindProperty(SupportsGet = true)]
        public int id { get; set; }
        public  CurrentPositionModel(ILogger<CurrentPositionModel> logger, JobGroupService jobcategoryService)
        {
            //_logger = logger;
            _jobcategoryService = jobcategoryService;
        }
        public async Task OnGetAsync(int id)
        {
            JobCategory = await _jobcategoryService.GetJobGroupById(id);
        }
    }
}
