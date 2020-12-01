﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Data.Classes.JobGroups;

namespace Web.Pages.CCGMember
{
    public class CurrentLevelModel : PageModel
    {
        private readonly JobGroupService _jobcategoryService;

        public JobGroupDto JobGroup { get; set; }
        public JobGroupPositionDto[] JobGroupPositions { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public CurrentLevelModel(ILogger<CurrentPositionModel> logger, JobGroupService jobcategoryService)
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