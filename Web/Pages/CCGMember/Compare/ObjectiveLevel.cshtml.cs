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
        public JobGroupPosition[] JobGroupPositions { get; set; }

        [BindProperty(SupportsGet = true)]
        public int level { get; set; }
        [BindProperty(SupportsGet = true)]
        public int positionid { get; set; }

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
        }
    }
}