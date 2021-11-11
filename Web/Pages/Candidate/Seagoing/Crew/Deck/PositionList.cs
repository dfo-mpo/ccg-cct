using System;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Candidate.Seagoing.Crew.Deck
{
    public class PositionListModel : PageModel
    {
        private readonly ILogger<PositionListModel> _logger;
        private readonly JobPositionService _jobpositionService;
        public JobPositionDto[] Positions { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }
        public PositionListModel(ILogger<PositionListModel> logger, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGet()
        {
            PositionIds = "PositionId=98&PositionId=99&PositionId=100&PositionId=101&PositionId=396&PositionId=102&PositionId=103&PositionId=104&PositionId=90&PositionId=91&PositionId=92";  
            _logger.LogInformation($"Seagoing Crew Deck similar positions list page visited at {DateTime.UtcNow.ToLongTimeString()}");
            Positions = await _jobpositionService.GetJobPositionByIdValues(PositionIds);
        }
    }
}