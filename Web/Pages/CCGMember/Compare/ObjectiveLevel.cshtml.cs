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
        public string PreviousPage { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PreviousPageCompare { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PreviousPageDetails { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Level { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string LevelObj { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; } = string.Empty;
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