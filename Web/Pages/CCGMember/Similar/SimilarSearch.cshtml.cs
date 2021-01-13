using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Business.Dtos.JobPositions;
using Business.Dtos.JobCompetencies;
using System.Collections.Generic;

namespace Web.Pages.CCGMember.Similar
{
    public class SimilarSearchModel : PageModel
    {
        private readonly ILogger<SimilarSearchModel> _logger;
        private readonly JobPositionService _jobpositionService;
        [BindProperty(SupportsGet = true)]
        public string PositionId { get; set; }
        public JobPositionDto Position { get; set; }
        public JobCertificateDto[] PositionCertificates { get; set; }
        public JobCompetencyRatingDto[] PositionRatings1 { get; set; }
        public JobCompetencyRatingDto[] PositionRatings2 { get; set; }
        public JobCompetencyRatingDto[] PositionRatings3 { get; set; }
        [BindProperty]
        public string EmailAddress { get; set; }
        [BindProperty(SupportsGet = true)]
        public Dictionary<string, int> ids { get; set; } = new Dictionary<string, int>();
        [BindProperty]
        public List<string> Type1Same { get; set; } = new List<string>();
        [BindProperty]
        public List<string> Type1Higher { get; set; } = new List<string>();
        [BindProperty]
        public List<string> Type2Same { get; set; } = new List<string>();
        [BindProperty]
        public List<string> Type2Higher { get; set; } = new List<string>();
        [BindProperty]
        public List<string> Type3Same { get; set; } = new List<string>();
        [BindProperty]
        public List<string> Type3Higher { get; set; } = new List<string>();
        [BindProperty]
        public string same1 { get; set; } = string.Empty;
        [BindProperty]
        public string same2 { get; set; } = string.Empty;
        [BindProperty]
        public string same3 { get; set; } = string.Empty;
        [BindProperty]
        public string higher1 { get; set; } = string.Empty;
        [BindProperty]
        public string higher2 { get; set; } = string.Empty;
        [BindProperty]
        public string higher3 { get; set; } = string.Empty;
        [BindProperty]
        public Dictionary<string, string> routenext { get; set; } = new Dictionary<string, string>();
        [BindProperty]
        public string routedata { get; set; } = string.Empty;
        [BindProperty]
        public Boolean pagesubmit { get; set; } = false;
        public SimilarSearchModel(ILogger<SimilarSearchModel> logger, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGetAsync(int positionid)
        {
            _logger.LogInformation($"Similar Position Search page visited at {DateTime.UtcNow.ToLongTimeString()}");
            Position = await _jobpositionService.GetJobPositionById(positionid);
            PositionCertificates = await _jobpositionService.GetJobCertificatesById(positionid);
            PositionRatings1 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(positionid, 1);
            PositionRatings2 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(positionid, 2);
            PositionRatings3 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(positionid, 3);
        }
        public void OnPost(int positionid)
        {
            pagesubmit = true;
            //public IActionResult OnPost(int positionid){ 
            foreach (var c in Type1Same)
            {
                same1 += c + "-";
            }

            foreach (var c in Type2Same)
            {
                same2 += c + "-";
            }

            foreach (var c in Type3Same)
            {
                same3 += c + "-";
            }

            foreach (var c in Type1Higher)
            {
                higher1 += c + "-";
            }

            foreach (var c in Type2Higher)
            {
                higher2 += c + "-";
            }

            foreach (var c in Type3Higher)
            {
                higher3 += c + "-";
            }

            routedata = positionid.ToString() + "!" + same1 + "%" + higher1 + "#" + same2 + "%" + higher2 + "#" + same3 + "%" + higher3;

            //return RedirectToPage("SimilarList", new { id = routedata }); // not working
        }
    }

}