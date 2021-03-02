using System;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Candidate.Seagoing.Officer.Navigation
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
            PositionIds = "PositionId=285&PositionId=297&PositionId=302&PositionId=110&PositionId=112&PositionId=113&PositionId=116&PositionId=117&PositionId=118&PositionId=120&PositionId=127&PositionId=128&PositionId=130" +
                "&PositionId=131&PositionId=133" +
                "&PositionId=139&PositionId=140&PositionId=142&PositionId=144" +
                "&PositionId=146&PositionId=148";
            _logger.LogInformation($"Seagoing Officer Navigation Similar positions list page visited at {DateTime.UtcNow.ToLongTimeString()}");
            Positions = await _jobpositionService.GetJobPositionByIdValues(PositionIds);
        }
    }
}