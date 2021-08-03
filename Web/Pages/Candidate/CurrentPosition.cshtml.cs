using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Candidate
{

    public class CurrentPositionModel : PageModel
    {
        private readonly ILogger<CurrentPositionModel> _logger;
        private readonly JobPositionService _jobpositionService;
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        [BindProperty(SupportsGet = true)]
        public int HLId { get; set; }
        [BindProperty]
        public string RouteParameter { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPage { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string Userpath { get; set; } 
        [BindProperty]
        public int Level { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PageSubmit { get; set; }
        [BindProperty]
        public JobPositionDto Position { get; set; }
        public JobLocationRegionDto[] JobLocationRegions { get; set; }
        public JobCertificateDto[] PositionCertificates { get; set; }
        public List<JobCompetencyRatingDto[]> PositionCompetencyRatings = new List<JobCompetencyRatingDto[]>() { };
        public CurrentPositionModel(ILogger<CurrentPositionModel> logger, JobPositionService jobcompetencyService)
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
            PageSubmit = "true";
            RouteParameter = String.Format($"jobPositionId={positionid}&jobGroupLevelId={Position.JobGroupLevelId}&jobGroupId={Position.JobGroupId}");

        }
    }
}