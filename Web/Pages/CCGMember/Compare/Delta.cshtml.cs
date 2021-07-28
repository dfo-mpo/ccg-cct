using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Business.Dtos.JobPositions;
using Business.Dtos.JobCompetencies;
using Business.Dtos.Shared;

namespace Web.Pages.CCGMember.Compare
{
    public class DeltaModel : PageModel
    {
        private readonly ILogger<DeltaModel> _logger;
        private readonly CompareService _compareService;
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public int HLId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string IdObj { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string LevelCode { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string LevelCodeObj { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string Level { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public int ObjectiveId { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string LevelObj { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string SubGroupCode { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SubGroupCodeObj { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PercentMatch { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SameLevels { get; set; }
        [BindProperty(SupportsGet = true)]
        public string HigherLevels { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SameOrHigherLevels { get; set; }
        [BindProperty(SupportsGet = true)]
        public string AddedCompetencies { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string RequiredCompetencies { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public List<int> AddedCompetencyId { get; set; } = new List<int>() { };
        [BindProperty(SupportsGet = true)]
        public string Certificates { get; set; }
        public JobPositionDto CurrentPosition { get; set; }
        public JobPositionDto ObjectivePosition { get; set; }
        [BindProperty]
        public JobLocationRegionDto[] MatchingJobLocationRegions { get; set; }
        [BindProperty]
        public SharedJobLocationRegionDto[] DifferingJobLocationRegions { get; set; }
        [BindProperty]
        public List<SharedJobCompetencyRating[]> MatchingCompetencies { get; set; } = new List<SharedJobCompetencyRating[]>();
        [BindProperty]
        public List<SharedJobCompetencyRating[]> DifferingCompetencies { get; set; } = new List<SharedJobCompetencyRating[]>();
        [BindProperty]
        public JobCertificateDto[] MatchingCertificates { get; set; }
        [BindProperty]
        public SharedJobCertificateDto[] DifferingCertificates { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PreviousPage { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPageCompare { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PreviousPageSimilar { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PreviousPageDetails { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PreviousPageDelta { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PreviousPageSimilarDetails { get; set; } = string.Empty;
        public DeltaModel(ILogger<DeltaModel> logger, CompareService compareService)
        {
            _logger = logger;
            _compareService = compareService;
        }
        public async Task OnGetAsync(int positionid, int objectiveid)
        {
            _logger.LogInformation($"Delta page visited at {DateTime.UtcNow.ToLongTimeString()}");

            CurrentPosition = await _compareService.GetJobPositionById(positionid);
            ObjectivePosition = await _compareService.GetJobPositionById(objectiveid);

            MatchingJobLocationRegions = await _compareService.GetMatchingJobLocationRegionsByPositionId(positionid, objectiveid);
            DifferingJobLocationRegions = await _compareService.GetDifferingJobLocationRegionsByPositionId(positionid, objectiveid);

            MatchingCertificates = await _compareService.GetMatchingCertificatesByPositionId(positionid, objectiveid);
            DifferingCertificates = await _compareService.GetDifferingCertificatesByPositionId(positionid, objectiveid);
            var CompetencyTypes = await _compareService.GetAllJobCompetencyTypes();
            foreach(var competencytype in CompetencyTypes)
            {
                var matchingcompetencies = await _compareService.GetMatchingCompetenciesByTypeId(competencytype.Id, positionid, objectiveid);
                if(!matchingcompetencies.Equals(null))
                {
                    MatchingCompetencies.Add(matchingcompetencies);
                }
                var differingcomptencies = await _compareService.GetDifferingCompetenciesByTypeId(competencytype.Id, positionid, objectiveid);
                if (!differingcomptencies.Equals(null))
                {
                    DifferingCompetencies.Add(differingcomptencies);
                }
            }

            foreach (var added in AddedCompetencies.Split("&addedCompetencyId="))
            {
                if (!string.IsNullOrEmpty(added))
                {
                    int number;
                    bool success = Int32.TryParse(added, out number);
                    if (success)
                    {
                        AddedCompetencyId.Add(number);
                    }
                }
            }

        }
    }
}