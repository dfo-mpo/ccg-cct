using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Business.Dtos.JobGroups;
using Business.Dtos.JobPositions;

namespace Web.Pages.CCGMember.Compare
{
    public class ObjectivePositionModel : PageModel
    {
        private readonly ILogger<ObjectivePositionModel> _logger;
        private readonly JobGroupService _jobcategoryService;
        public JobGroupDto JobGroup { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Level { get; set; }

        public JobGroupPositionDto[] JobGroupLevels { get; set; }
        public JobPositionDto[] JobGroupPositions { get; set; }

        public ObjectivePositionModel(ILogger<ObjectivePositionModel> logger, JobGroupService jobcategoryService)
        {
            _logger = logger;
            _jobcategoryService = jobcategoryService;
        }
        public async Task OnGetAsync(int id, int level)
        {
            _logger.LogInformation($"Objective positions page visited at {DateTime.UtcNow.ToLongTimeString()}");
            JobGroup = await _jobcategoryService.GetJobGroupById(id);
            JobGroupLevels = await _jobcategoryService.GetJobGroupPositionsById(id);
            JobGroupPositions = await _jobcategoryService.GetJobGroupPositionsByLevel(id, level);
        }
    }
}
