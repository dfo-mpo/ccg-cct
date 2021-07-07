using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using SmartBreadcrumbs.Attributes;

namespace Web.Pages.Student.University.Seagoing.Officer
{
    [Breadcrumb("Logistics", FromPage = typeof(Officer.IndexModel))]
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
            _logger.LogInformation($"University Seagoing Officer Logistics positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Seagoing
            //Ship's Logistics MAO-02 (logistics)
            SeagoingPositionIds = "&PositionId=108";
            SeagoingPositions = await _jobpositionService.GetJobPositionByIdValues(SeagoingPositionIds);
        }
    }
}
