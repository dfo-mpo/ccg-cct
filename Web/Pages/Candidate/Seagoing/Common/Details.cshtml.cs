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
        public List<string> CertificateIds { get; set; } = new List<string>();
        [BindProperty]
        public string RouteParameter { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string Certificates { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPage { get; set; } = string.Empty;
        [BindProperty]
        public int Level { get; set; }
        [BindProperty]
        public int GroupId { get; set; }
        [BindProperty(SupportsGet = true)]
        public bool PageSubmit { get; set; } = false;
        [BindProperty]
        public JobPositionDto Position { get; set; }
        public JobCertificateDto[] PositionCertificates { get; set; }
        public List<JobCompetencyRatingDto[]> PositionCompetencyRatings = new List<JobCompetencyRatingDto[]>(){};
        public DetailsModel(ILogger<DetailsModel> logger, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGetAsync(int positionid)
        {
            _logger.LogInformation($"Candidate Seagoing details page visited at {DateTime.UtcNow.ToLongTimeString()}");
            if (!Certificates.Equals(string.Empty))
            {
                var ids = Certificates.Split("&certificateId=");
                foreach (var id in ids)
                {
                    CertificateIds.Add(id);
                }
            }
            Position = await _jobpositionService.GetJobPositionById(positionid);
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
            Position = await _jobpositionService.GetJobPositionById(positionid);
            PageSubmit = true;

            foreach (var c in CertificateIds)
            {
                Certificates += "&certificateId=" + c;
            }

            RouteParameter = String.Format($"jobPositionId={positionid}&jobGroupLevelId={Position.JobGroupLevelId}&jobGroupId={Position.JobGroupId}{Certificates}");

        }
    }
}