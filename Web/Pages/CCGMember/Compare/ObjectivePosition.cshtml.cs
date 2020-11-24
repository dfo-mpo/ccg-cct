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

namespace Web.Pages.CCGMember.Compare
{
    public class ObjectivePositionModel : PageModel
    {
        private readonly JobGroupService _jobcategoryService;
        public JobGroup JobGroup { get; set; }
        [BindProperty(SupportsGet = true)]
        public int current { get; set; }
        [BindProperty(SupportsGet = true)]
        public int id { get; set; }

        [BindProperty(SupportsGet = true)]
        public int level { get; set; }

        public JobGroupPosition[] JobGroupLevels { get; set; }
        public JobPosition[] JobGroupPositions { get; set; }

        public ObjectivePositionModel(ILogger<ObjectivePositionModel> logger, JobGroupService jobcategoryService)
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
