using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Admin.Data;
using Business.Dtos.JobPositions;
using Business.Dtos.JobCompetencies;
using System.Collections.Generic;

namespace Admin.Pages.Positions
{
    public class DetailsModel : PageModel
    {
        private readonly ILogger<DetailsModel> _logger;
        private readonly JobPositionService _jobpositionService;
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Level { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SubGroupCode { get; set; }
        [BindProperty(SupportsGet = true)]
        public string LevelCode { get; set; }
        public JobPositionDto Position { get; set; }
        public JobCertificateDto[] PositionCertificates { get; set; }
        [BindProperty]
        public List<JobCompetencyRatingDto[]> PositionCompetencyRatings { get; set; } = new List<JobCompetencyRatingDto[]>();

        public DetailsModel(ILogger<DetailsModel> logger, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGetAsync(int positionid)
        {
            Position = await _jobpositionService.GetJobPositionById(positionid);
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
        }
    }

}