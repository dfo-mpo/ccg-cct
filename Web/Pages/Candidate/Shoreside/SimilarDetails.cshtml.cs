using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Candidate.Shoreside
{

    public class SimilarDetailsModel : PageModel
    {
        private readonly ILogger<SimilarDetailsModel> _logger;
        private readonly JobPositionService _jobpositionService;
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        [BindProperty]
        public List<string> CertificateIds { get; set; } = new List<string>();
        [BindProperty]
        public string RouteParameter { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string Certificates { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPage { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPageList { get; set; } = string.Empty;
        [BindProperty]
        public int Level { get; set; }
        [BindProperty]
        public int GroupId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PageSubmit { get; set; } = string.Empty;
        [BindProperty]
        public JobPositionDto Position { get; set; }
        public JobLocationRegionDto[] JobLocationRegions { get; set; }
        public JobCertificateDto[] PositionCertificates { get; set; }
        [BindProperty]
        public List<JobCompetencyRatingDto[]> PositionCompetencyRatings { get; set; } = new List<JobCompetencyRatingDto[]>();
        public List<int> SimilarSearchIds { get; set; }
        public SimilarDetailsModel(ILogger<SimilarDetailsModel> logger, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGetAsync(int positionid)
        {
            if (!Certificates.Equals(string.Empty))
            {
                var ids = Certificates.Split("&certificateId=");
                foreach (var id in ids)
                {
                    CertificateIds.Add(id);
                }
            }
            _logger.LogInformation($"Candidate Shoreside Similar details page visited at {DateTime.UtcNow.ToLongTimeString()}");
            Position = await _jobpositionService.GetJobPositionById(positionid);
            JobLocationRegions = await _jobpositionService.GetJobLocationRegionsById(positionid);
            Id = Position.JobGroupId;
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
                PageSubmit = "true";

                foreach (var c in CertificateIds)
                {
                    Certificates += "&certificateId=" + c;
                }

                RouteParameter = String.Format($"jobPositionId={positionid}&jobGroupLevelId={Position.JobGroupLevelId}&jobGroupId={Position.JobGroupId}{Certificates}");
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