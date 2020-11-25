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
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Pages.CCGMember
{
    public class CurrentPositionModel : PageModel
    {
        private readonly JobGroupService _jobcategoryService;
        public JobGroup JobGroup { get; set; }
        [BindProperty(SupportsGet = true)]
        public string id { get; set; }

        [BindProperty(SupportsGet = true)]
        public string level { get; set; }

        public JobGroupPosition[] JobGroupLevels { get; set; }
        public JobPosition[] JobGroupPositions { get; set; }

        public  CurrentPositionModel(ILogger<CurrentPositionModel> logger, JobGroupService jobcategoryService)
        {
            //_logger = logger;
            _jobcategoryService = jobcategoryService;
        }
        public async Task OnGetAsync(int id, int level)
        {
            JobGroup = await _jobcategoryService.GetJobGroupById(id);
            JobGroupLevels = await _jobcategoryService.GetJobGroupPositionsById(id);
            JobGroupPositions = await _jobcategoryService.GetJobGroupPositionsByLevel(id, level);    
        }

    }
}
