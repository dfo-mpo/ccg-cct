using System;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Candidate.Seagoing.Crew.Logistics
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
            PositionIds = "PositionId=93&PositionId=94&PositionId=95&PositionId=96&PositionId=97";  
            _logger.LogInformation($"Seagoing Crew Logistics Similar positions list page visited at {DateTime.UtcNow.ToLongTimeString()}");
            Positions = await _jobpositionService.GetJobPositionByIdValues(PositionIds);
        }
    }
}