using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Business.Dtos.JobGroups;


namespace Web.Pages.CCGMember.Compare
{
    public class ObjectiveLevelModel : PageModel
    {
        private readonly ILogger<ObjectiveLevelModel> _logger;
        private readonly JobGroupService _jobcategoryService;
        public JobGroupDto JobGroup { get; set; }
        public JobGroupPositionDto[] JobGroupPositions { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Level { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public ObjectiveLevelModel(ILogger<ObjectiveLevelModel> logger, JobGroupService jobcategoryService)
        {
            _logger = logger;
            _jobcategoryService = jobcategoryService;
        }
        public async Task OnGetAsync(int id)
        {
            _logger.LogInformation($"Objective levels page visited at {DateTime.UtcNow.ToLongTimeString()}");
            JobGroup = await _jobcategoryService.GetJobGroupById(id);
            JobGroupPositions = await _jobcategoryService.GetJobGroupPositionsById(id);
        }
    }
}