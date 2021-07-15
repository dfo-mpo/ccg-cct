 using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using SmartBreadcrumbs.Attributes;

namespace Web.Pages.Student.University.Shoreside
{
    [Breadcrumb("Sciences", FromPage = typeof(Shoreside.IndexModel))]
    public class SciencesModel : PageModel
    {
        private readonly ILogger<SciencesModel> _logger;
        private readonly JobGroupService _jobgroupService;
        private readonly JobPositionService _jobpositionService;

        public List<JobPositionDto> ShoreSidePositions = new List<JobPositionDto> { };
        [BindProperty(SupportsGet = true)]
        public string ShoresidePositionIds { get; set; } = "&PositionId=";
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }

        public SciencesModel(ILogger<SciencesModel> logger, JobGroupService jobgroupService, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"University Student Shoreside Sciences positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Shoreside
            //Nursing NU (CHN-03)
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(18,"CHN","03"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
        }
    }
}