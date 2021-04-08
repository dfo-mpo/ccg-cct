using System;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.CCGMember.Similar
{
    public class SimilarListModel : PageModel
    {
        private readonly ILogger<SimilarListModel> _logger;
        private readonly SimilarService _similarService;
        public JobPositionDto[] Positions { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        [BindProperty]
        public string RouteParameter { get; set; }
        public JobPositionDto Position { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string Level { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string LevelObj { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PercentMatch { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SameLevels { get; set; }
        [BindProperty(SupportsGet = true)]
        public string HigherLevels { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SameOrHigherLevels { get; set; }
        [BindProperty(SupportsGet = true)]
        public string AddedCompetencies { get; set; }
        [BindProperty(SupportsGet = true)]
        public string RequiredCompetencies { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string Certificates { get; set; } 
        [BindProperty(SupportsGet = true)]
        public string PreviousPage { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPageSimilar { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPageDetails { get; set; } = string.Empty;
        public SimilarListModel(ILogger<SimilarListModel> logger, SimilarService similarService)
        {
            _logger = logger;
            _similarService = similarService;
        }
        public async Task OnGet(int positionid)
        {
            _logger.LogInformation($"Similar positions list page visited at {DateTime.UtcNow.ToLongTimeString()}");
            Position = await _similarService.GetJobPositionById(PositionId);
            RouteParameter = String.Format($"jobPositionId={positionid}{RequiredCompetencies}{SameLevels}{HigherLevels}{SameOrHigherLevels}{AddedCompetencies}{Certificates}{PercentMatch}");
            Positions = await _similarService.GetAllSimilarJobPositionsByPositionId(RouteParameter);       
        }
    }
}