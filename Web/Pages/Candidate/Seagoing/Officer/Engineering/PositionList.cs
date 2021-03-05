using System;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Candidate.Seagoing.Officer.Engineering
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
            PositionIds = "PositionId=109&PositionId=114&PositionId=115&PositionId=119&PositionId=124&PositionId=125&PositionId=126&PositionId=132&PositionId=134&PositionId=136&PositionId=137&PositionId=138&PositionId=141&PositionId=143&PositionId=145&PositionId=147";  
            _logger.LogInformation($"Seagoing Officer Engineering Similar positions list page visited at {DateTime.UtcNow.ToLongTimeString()}");
            Positions = await _jobpositionService.GetJobPositionByIdValues(PositionIds);
        }
    }
}