using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Business.Dtos.JobGroups;
using Business.Dtos.JobPositions;

namespace Web.Pages.CCGMember
{
    public class CurrentPositionModel : PageModel
    {
        private readonly ILogger<CurrentPositionModel> _logger;
        private readonly JobGroupService _jobcategoryService;
        public JobGroupDto JobGroup { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Level { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SubGroupCode { get; set; }
        [BindProperty(SupportsGet = true)]
        public string LevelCode { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; } = 0;
        public JobPositionDto Position { get; set; }

        public JobGroupPositionDto[] JobGroupLevels { get; set; }
        public JobPositionDto[] JobGroupPositions { get; set; }

        public  CurrentPositionModel(ILogger<CurrentPositionModel> logger, JobGroupService jobcategoryService)
        {
            _logger = logger;
            _jobcategoryService = jobcategoryService;
        }
        public async Task OnGetAsync(int id, string level, string subgroupcode, int positionid)
        {
            _logger.LogInformation($"Current position selection page visited at {DateTime.UtcNow.ToLongTimeString()}");
            JobGroup = await _jobcategoryService.GetJobGroupById(id);
            JobGroupLevels = await _jobcategoryService.GetSubGroupLevelsByGroupId(id);
            JobGroupPositions = string.IsNullOrEmpty(subgroupcode) ? await _jobcategoryService.GetJobGroupPositionsByLevel(id, level) : await _jobcategoryService.GetJobGroupPositionsBySubGroupLevel(id, subgroupcode, level); 
            Position = positionid == 0 ? null : await _jobcategoryService.GetJobPositionById(positionid);
        }

    }
}
