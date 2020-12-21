using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Business.Dtos.JobGroups;

namespace Web.Pages.CCGMember.Compare
{
    public class AllObjectiveModel : PageModel
    {
        private readonly ILogger<AllObjectiveModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public JobGroupDto[] JobGroups { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Filter { get; set; }
        public AllObjectiveModel(ILogger<AllObjectiveModel> logger, JobGroupService jobgroupService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGetAsync()
        {
            _logger.LogInformation($"All objective positions page visited at {DateTime.UtcNow.ToLongTimeString()}");
            JobGroups = await _jobgroupService.GetJobGroups();
        }

    }
}