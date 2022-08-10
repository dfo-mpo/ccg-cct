using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Admin.Data;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.Extensions.Logging;
using Business.Dtos.JobCompetencies;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Business.Dtos.JobGroups;
using System.Threading;

namespace Admin.Pages.Positions
{
    public class AllDetailsModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        private readonly JobPositionService _jobPositionService;
        private readonly JobCompetencyService _jobCompetencyService;

        public AllDetailsModel(DataModel.CctDbContext context, JobPositionService jobPositionService, JobCompetencyService jobCompetencyService)
        {
            _context = context;
            _jobPositionService = jobPositionService;
            _jobCompetencyService = jobCompetencyService;
        }

        public bool DisplayTopOfPage { get; set; }

        public double LastTableContainerHeight { get; set; } = 300;

        public IList<JobPositionDto> JobPositions { get; set; }

        public List<JobPositionDetails> AllPositionDetails { get; set; }

        public List<CompetencyType> CompetencyTypeNames { get; set; }

        public class JobPositionDetails
        {
            public JobPositionDto Position { get; set; }
            public JobLocationRegionDto[] JobLocationRegions { get; set; }
            public JobCertificateDto[] PositionCertificates { get; set; }
            public List<JobCompetencyRatingDto[]> PositionCompetencyRatings { get; set; } = new List<JobCompetencyRatingDto[]>();
            public string JobHLCategory { get; set; } = string.Empty;
        }

        public async Task OnGetAsync()
        {
            JobPositions = await _jobPositionService.GetAllJobPositions();

            DisplayTopOfPage = true;
            var sessionStr = HttpContext.Session.GetString("displayTopOfPage");
            if (!string.IsNullOrEmpty(sessionStr))
            {
                if (sessionStr.ToLower() == "false")
                {
                    DisplayTopOfPage = false;
                }
            }
            sessionStr = HttpContext.Session.GetString("lastTableContainerHeight");
            if (!string.IsNullOrEmpty(sessionStr))
            {
                if (double.TryParse(sessionStr, out double num))
                {
                    if (num > 300)
                    {
                        LastTableContainerHeight = num;
                    }
                }
            }

            AllPositionDetails = new List<JobPositionDetails>();

            CompetencyTypeNames = await _context.CompetencyTypes.ToListAsync();
            CompetencyTypeNames = CompetencyTypeNames.OrderBy(x => x.Id).ToList();

            JobPositions = JobPositions.Where(x => x.Active == 1).ToList();

            // when testing this page, I'd recommend reducing the number of positions loaded by uncommenting the line below
            //JobPositions = JobPositions.Where(x => x.JobTitleId < 30).ToList();

            var activeCertDescIds = await _context.CertificateDescriptions.Where(x => x.Active == 1).Select(x => x.Id).ToListAsync();
            var CompetencyTypes = await _jobPositionService.GetAllJobCompetencyTypes();
            CompetencyTypes = CompetencyTypes.OrderBy(x => x.Id).ToArray();

            // this page gets all the same information as the Position Details page, except for all positions!
            foreach (var pos in JobPositions)
            {
                int posId = pos.JobTitleId;

                var JobLocationRegions = await _jobPositionService.GetJobLocationRegionsById(posId);
                JobLocationRegions = JobLocationRegions.OrderBy(x => x.JobLocationRegionId).ToArray();

                var PositionCertificates = await _jobPositionService.GetJobCertificatesById(posId);
                PositionCertificates = PositionCertificates.OrderBy(x => x.NameEng.ToLower()).ToArray();

                var jobHLCategory = await _jobCompetencyService.GetJobPositionHLCategoryIdByPositionId(posId);
                var strJobHLCategory = jobHLCategory.ToString();

                int loopCounter = 0;
                // this loop makes sure that inactive certificate descriptions don't get displayed
                PositionCertificates = PositionCertificates.Where(x => x.Active == 1).ToArray();
                foreach (var cert in PositionCertificates)
                {
                    if (!activeCertDescIds.Contains(cert.CertificateDescId))
                    {
                        PositionCertificates.ElementAt(loopCounter).DescEng = "";
                        PositionCertificates.ElementAt(loopCounter).DescFre = "";
                    }
                    loopCounter++;
                }

                var PositionCompetencyRatings = new List<JobCompetencyRatingDto[]>();

                foreach (var competencytype in CompetencyTypes)
                {
                    var competencies = await _jobPositionService.GetJobCompetencyRatingsByTypeId(posId, competencytype.Id);
                    if (competencies != null)
                    {
                        competencies = competencies.Where(x => x.Active == 1).ToArray();
                        PositionCompetencyRatings.Add(competencies);
                    }
                }

                var posDetails = new JobPositionDetails
                {
                    Position = pos,
                    JobLocationRegions = JobLocationRegions,
                    PositionCertificates = PositionCertificates,
                    PositionCompetencyRatings = PositionCompetencyRatings,
                    JobHLCategory = strJobHLCategory
                };
                AllPositionDetails.Add(posDetails);
            }

            AllPositionDetails.ToString();

        }
    }
}
