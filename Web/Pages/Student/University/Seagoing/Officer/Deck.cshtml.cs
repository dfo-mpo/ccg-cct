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
    [Breadcrumb("Deck", FromPage = typeof(Officer.IndexModel))]
    public class DeckModel : PageModel
    {
        private readonly ILogger<DeckModel> _logger;
        private readonly JobGroupService _jobgroupService;
        private readonly JobPositionService _jobpositionService;
        public string PositionIds { get; set; }
        [BindProperty(SupportsGet = true)]

        public JobPositionDto[] SeagoingPositions { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SeagoingPositionIds { get; set; }
        public DeckModel(ILogger<DeckModel> logger, JobGroupService jobgroupService, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"University Seagoing Officer Deck positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Seagoing
            //Ship's Officer MAO-02, MAO-03 (deck)
            SeagoingPositionIds = "&PositionId=110&PositionId=112&PositionId=116";
            SeagoingPositions = await _jobpositionService.GetJobPositionByIdValues(SeagoingPositionIds);
        }
    }
}