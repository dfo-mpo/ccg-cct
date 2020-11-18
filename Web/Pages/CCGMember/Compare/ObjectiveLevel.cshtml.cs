using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.CCGMember.Compare
{
    public class ObjectiveLevelModel : PageModel
    {
        private readonly JobGroupService _jobcategoryService;
        public JobGroup JobGroup { get; set; }

        [BindProperty]
        public int level { get; set; }

        public JobGroupLevel[] JobGroupLevels { get; set; }
        public JobGroupPosition[] JobGroupPositions { get; set; }
        [BindProperty(SupportsGet = true)]
        public int current { get; set; }

        [BindProperty(SupportsGet = true)]
        public int id { get; set; }
        public ObjectiveLevelModel(ILogger<ObjectiveLevelModel> logger, JobGroupService jobcategoryService)
        {
            //_logger = logger;
            _jobcategoryService = jobcategoryService;
        }
        public async Task OnGetAsync(int id)
        {
            JobGroup = await _jobcategoryService.GetJobGroupById(id);
            JobGroupPositions = await _jobcategoryService.GetJobGroupPositionsById(id);
            //var er = Request.Form["dt_level"];

            //JobGroupLevels = await _jobcategoryService.GetJobGroupLevelsById(id);

        }
        public void OnPostEdit(int id)
        {

            //JobGroup = await _jobcategoryService.GetJobGroupById(3);
            //JobGroupPositions = await _jobcategoryService.GetJobGroupPositionsById(3);

        }
    }
}