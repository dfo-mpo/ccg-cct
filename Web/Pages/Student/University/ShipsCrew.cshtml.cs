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
    public class ShipsCrewModel : PageModel
    {
        private readonly ILogger<ShipsCrewModel> _logger;
        private readonly JobGroupService _jobgroupService;
        private readonly JobPositionService _jobpositionService;
        public List<JobPositionDto> ShoreSidePositions = new List<JobPositionDto> { };
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ShoresidePositionIds { get; set; } = "&PositionId=";
        [BindProperty(SupportsGet = true)]

        public JobPositionDto[] SeagoingPositions { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SeagoingPositionIds { get; set; }
        public ShipsCrewModel(ILogger<ShipsCrewModel> logger, JobGroupService jobgroupService, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"University Student Ships' Crew positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Seagoing
            //Ship's Crew DED & MAO levels 2-3 (deck)
            SeagoingPositionIds = "&PositionId=98&PositionId=99&PositionId=100&PositionId=109&PositionId=112&PositionId=113";
            SeagoingPositions = await _jobpositionService.GetJobPositionByIdValues(SeagoingPositionIds);
        }
    }
}