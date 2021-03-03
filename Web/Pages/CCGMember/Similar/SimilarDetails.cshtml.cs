using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Rotativa.AspNetCore;
using Web.Data;

namespace Web.Pages.CCGMember.Similar
{
    public class SimilarDetailsModel : PageModel
    {
        private readonly ILogger<SimilarDetailsModel> _logger;
        private readonly JobPositionService _jobpositionService;
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        [BindProperty(SupportsGet = true)]
        public int ObjectiveId { get; set; }
        public JobPositionDto Position { get; set; }
        public JobCertificateDto[] PositionCertificates { get; set; }
        public JobCompetencyRatingDto[] PositionRatings1 { get; set; }
        public JobCompetencyRatingDto[] PositionRatings2 { get; set; }
        public JobCompetencyRatingDto[] PositionRatings3 { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PercentMatch { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SameLevels { get; set; }
        [BindProperty(SupportsGet = true)]
        public string HigherLevels { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SameOrHigherLevels { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Certificates { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PreviousPage { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PreviousPageDetails { get; set; } = string.Empty;
        public SimilarDetailsModel(ILogger<SimilarDetailsModel> logger, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGetAsync(int objectiveid)
        {
            _logger.LogInformation($"Position details page visited at {DateTime.UtcNow.ToLongTimeString()}");
            Position = await _jobpositionService.GetJobPositionById(objectiveid);
            PositionCertificates = await _jobpositionService.GetJobCertificatesById(objectiveid);
            PositionRatings1 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(objectiveid, 1);
            PositionRatings2 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(objectiveid, 2);
            PositionRatings3 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(objectiveid, 3);
        }
    }
}