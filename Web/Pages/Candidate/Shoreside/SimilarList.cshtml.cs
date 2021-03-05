using System;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Business.Dtos.JobGroups;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Candidate.Shoreside
{
    public class SimilarListModel : PageModel
    {
        private readonly ILogger<SimilarListModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public JobPositionDto[] Positions { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        public JobGroupDto JobGroup { get; set; }
        [BindProperty]
        public string PositionIds { get; set; } = string.Empty;
        public SimilarListModel(ILogger<SimilarListModel> logger, JobGroupService jobgroupService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGet(int id)
        {

            _logger.LogInformation($"Candidate Shoreside Similar positions list page visited at {DateTime.UtcNow.ToLongTimeString()}");
            JobGroup = await _jobgroupService.GetJobGroupById(id);
            Positions = await _jobgroupService.GetJobPositionsByGroupId(id);

            foreach(var position in Positions)
            {
                PositionIds += "&PositionId="+position.JobTitleId.ToString();
            }
        }
    }
}