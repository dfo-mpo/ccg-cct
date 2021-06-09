 using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Student.University
{
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

        public JobPositionDto[] SeagoingPositions { get; set; }
        public string SeagoingPositionIds { get; set; }

        public SciencesModel(ILogger<SciencesModel> logger, JobGroupService jobgroupService, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"University Student Sciences positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

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

            
            //Seagoing
            //Ship's Officer MAO-02 to MAO-03 (deck)
            SeagoingPositionIds = "&PositionId=108&PositionId=110&PositionId=111&PositionId=112&PositionId=113&PositionId=116";
            SeagoingPositions = await _jobpositionService.GetJobPositionByIdValues(SeagoingPositionIds);
        }
    }
}