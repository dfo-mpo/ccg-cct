using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using SmartBreadcrumbs.Attributes;

namespace Web.Pages.Student.University.Seagoing.Crew
{
    [Breadcrumb("Logistics", FromPage = typeof(Crew.IndexModel))]
    public class LogisticsModel : PageModel
    {
        private readonly ILogger<LogisticsModel> _logger;
        private readonly JobGroupService _jobgroupService;
        private readonly JobPositionService _jobpositionService;
        public string PositionIds { get; set; }
        [BindProperty(SupportsGet = true)]

        public JobPositionDto[] SeagoingPositions { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SeagoingPositionIds { get; set; }
        public LogisticsModel(ILogger<LogisticsModel> logger, JobGroupService jobgroupService, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"University Seagoing Crew Logistics positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Seagoing
            //Ship's Logistics STD-01, STD-03 (logistics)
            SeagoingPositionIds = "&PositionId=93&PositionId=94";
            SeagoingPositions = await _jobpositionService.GetJobPositionByIdValues(SeagoingPositionIds);
        }
    }
}