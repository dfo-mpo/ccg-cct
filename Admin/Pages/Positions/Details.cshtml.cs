using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Admin.Data;
using Business.Dtos.JobPositions;
using Business.Dtos.JobCompetencies;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Business.Dtos.JobGroups;
using System.Threading;

namespace Admin.Pages.Positions
{
    public class DetailsModel : PageModel
    {
        private readonly ILogger<DetailsModel> _logger;
        private readonly JobCompetencyService _jobCompetencyService;
        private readonly JobPositionService _jobpositionService;
        private readonly CctDbContext _context;

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
        public JobLocationRegionDto[] JobLocationRegions { get; set; }
        public JobCertificateDto[] PositionCertificates { get; set; }
        [BindProperty]
        public List<JobCompetencyRatingDto[]> PositionCompetencyRatings { get; set; } = new List<JobCompetencyRatingDto[]>();

        public string JobHLCategory { get; set; } = string.Empty;

        public List<DataModel.CompetencyType> CompetencyTypeNames { get; set; }

        public DetailsModel(ILogger<DetailsModel> logger, JobPositionService jobpositionService, CctDbContext context, JobCompetencyService jobCompetencyService)
        {
            _logger = logger;
            _jobpositionService = jobpositionService;
            _context = context;
            _jobCompetencyService = jobCompetencyService;
        }

        public async Task<List<DataModel.CompetencyRatingLevel>> GetCompetencyLevelDescriptions()
        {
            return await _context.CompetencyRatingLevels.ToListAsync();
        }

        public async Task<IActionResult> OnGetAsync(int? positionid)
        {
            if (positionid == null)
            {
                return NotFound();
            }
            Position = await _jobpositionService.GetJobPositionById(positionid.Value);
            if (Position == null)
            {
                return NotFound();
            }
            if (Position.Active != 1)
            {
                return NotFound();
            }
            JobLocationRegions = await _jobpositionService.GetJobLocationRegionsById(positionid.Value);
            PositionCertificates = await _jobpositionService.GetJobCertificatesById(positionid.Value);

            var jobHLCategory = await _jobCompetencyService.GetJobPositionHLCategoryIdByPositionId(positionid.Value);
            JobHLCategory = jobHLCategory.ToString();

            int loopCounter = 0;
            // this loop makes sure that inactive certificate descriptions don't get displayed
            foreach (var cert in PositionCertificates)
            {
                var certDesc = _context.CertificateDescriptions.Where(x => x.Id == cert.CertificateDescId).FirstOrDefault();
                if (certDesc.Active != 1)
                {
                    PositionCertificates.ElementAt(loopCounter).DescEng = "";
                    PositionCertificates.ElementAt(loopCounter).DescFre = "";
                }
                loopCounter++;
            }
            CompetencyTypeNames = await _context.CompetencyTypes.ToListAsync();
            CompetencyTypeNames = CompetencyTypeNames.OrderBy(x => x.Id).ToList();

            var CompetencyTypes = await _jobpositionService.GetAllJobCompetencyTypes();
            foreach (var competencytype in CompetencyTypes.OrderBy(x => x.Id))
            {
                var competencies = await _jobpositionService.GetJobCompetencyRatingsByTypeId(positionid.Value, competencytype.Id);
                if (!competencies.Equals(null))
                {
                    PositionCompetencyRatings.Add(competencies);
                }
            }
            return Page();
        }
    }

}