using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Candidate.Seagoing.Common
{

    public class DetailsModel : PageModel
    {
        private readonly ILogger<DetailsModel> _logger;
        private readonly JobPositionService _jobpositionService;
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        [BindProperty]
        public string RouteParameter { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPage { get; set; } = string.Empty;
        [BindProperty]
        public int Level { get; set; }
        [BindProperty]
        public int GroupId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PageSubmit { get; set; } 
        [BindProperty]
        public JobPositionDto Position { get; set; }
        public JobLocationRegionDto[] JobLocationRegions { get; set; }
        public JobCertificateDto[] PositionCertificates { get; set; }
        public List<JobCompetencyRatingDto[]> PositionCompetencyRatings = new List<JobCompetencyRatingDto[]>(){};
        public List<int> SimilarSearchIds { get; set; }
        public DetailsModel(ILogger<DetailsModel> logger, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGetAsync(int positionid)
        {
            _logger.LogInformation($"Candidate Seagoing details page visited at {DateTime.UtcNow.ToLongTimeString()}");
            Position = await _jobpositionService.GetJobPositionById(positionid);
            JobLocationRegions = await _jobpositionService.GetJobLocationRegionsById(positionid);
            Level = Position.JobGroupLevelId;
            Level = Position.JobGroupLevelId;
            GroupId = Position.JobGroupId;
            PositionCertificates = await _jobpositionService.GetJobCertificatesById(positionid);
            var CompetencyTypes = await _jobpositionService.GetAllJobCompetencyTypes();
            foreach (var competencytype in CompetencyTypes)
            {
                var competencies = await _jobpositionService.GetJobCompetencyRatingsByTypeId(positionid, competencytype.Id);
                if (!competencies.Equals(null))
                {
                    PositionCompetencyRatings.Add(competencies);
                }
            }
            RouteParameter = String.Format($"jobPositionId={positionid}&jobGroupLevelId={Position.JobGroupLevelId}&jobGroupId={Position.JobGroupId}");
        }

        public async Task OnPost(int positionid)
        {
            SimilarSearchIds = await _jobpositionService.GetAllSimilarSearchIds();
            if (SimilarSearchIds.Contains(positionid))
            {
                Position = await _jobpositionService.GetJobPositionById(positionid);
                JobLocationRegions = await _jobpositionService.GetJobLocationRegionsById(positionid);
                Level = Position.JobGroupLevelId;
                PageSubmit = "true";
                RouteParameter = String.Format($"jobPositionId={positionid}&jobGroupLevelId={Position.JobGroupLevelId}&jobGroupId={Position.JobGroupId}");
  
                    var SimilarJobIds100 = await _jobpositionService.GetAllHundredPercentSimilarPositionsByPositionId(positionid);
                    var SimilarJobIds90 = await _jobpositionService.GetAllNinetyPercentSimilarPositionsByPositionId(positionid);
                    var SimilarJobIds80 = await _jobpositionService.GetAllEightyPercentSimilarPositionsByPositionId(positionid);
                    var SimilarJobIds70 = await _jobpositionService.GetAllSeventyPercentSimilarPositionsByPositionId(positionid);
                    if (SimilarJobIds100.SimilarPositionIds == "" && SimilarJobIds90.SimilarPositionIds == "" && SimilarJobIds80.SimilarPositionIds == "" && SimilarJobIds70.SimilarPositionIds == "")
                    {
                        PageSubmit = "Error";
                    }
                
            }
            else
            {
                PageSubmit = "Error";
            }
        }
    }
}