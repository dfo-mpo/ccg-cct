using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Business.Dtos.JobGroups;
using System;

namespace Web.Pages.CCGMember
{
    public class CurrentLevelModel : PageModel
    {
        private readonly ILogger<CurrentLevelModel> _logger;
        private readonly JobGroupService _jobcategoryService;
        public JobGroupDto JobGroup { get; set; }
        public JobGroupPositionDto[] JobGroupPositions { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public CurrentLevelModel(ILogger<CurrentLevelModel> logger, JobGroupService jobcategoryService)
        {
            _logger = logger;
            _jobcategoryService = jobcategoryService;
        }
        public async Task OnGetAsync(int id)
        {
            _logger.LogInformation($"Current level page visited at {DateTime.UtcNow.ToLongTimeString()}");
            JobGroup = await _jobcategoryService.GetJobGroupById(id);
            JobGroupPositions = await _jobcategoryService.GetJobGroupPositionsById(id);
        }

    }
}