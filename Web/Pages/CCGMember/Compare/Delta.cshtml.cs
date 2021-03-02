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
        public int Id { get; set; } = 0;
        [BindProperty(SupportsGet = true)]
        public string Level { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public int Obj { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        public JobPositionDto CurrentPosition { get; set; }
        public JobPositionDto ObjectivePosition { get; set; }
        [BindProperty]
        public List<SharedJobCompetencyRating[]> MatchingCompetencies { get; set; } = new List<SharedJobCompetencyRating[]>();
        [BindProperty]
        public List<SharedJobCompetencyRating[]> DifferingCompetencies { get; set; } = new List<SharedJobCompetencyRating[]>();
        public JobCompetencyDto[] CompetencyTypes { get; set; }
        [BindProperty]
        public JobCertificateDto[] MatchingCertificates { get; set; }
        [BindProperty]
        public JobCertificateDto[] DifferingCertificates { get; set; }

        public DeltaModel(ILogger<DeltaModel> logger, CompareService compareService)
        {
            _logger = logger;
            _compareService = compareService;
        }
        public async Task OnGetAsync(int positionid, int obj)
        {
            _logger.LogInformation($"Delta page visited at {DateTime.UtcNow.ToLongTimeString()}");

            CurrentPosition = await _compareService.GetJobPositionById(positionid);
            ObjectivePosition = await _compareService.GetJobPositionById(obj);

            MatchingCertificates = await _compareService.GetMatchingCertificatesByPositionId(positionid, obj);
            DifferingCertificates = await _compareService.GetDifferingCertificatesByPositionId(positionid, obj);

            CompetencyTypes = await _compareService.GetAllJobCompetencyTypes();
            foreach(var competencytype in CompetencyTypes)
            {
                var matchingcompetencies = await _compareService.GetMatchingCompetenciesByTypeId(competencytype.Id, positionid, obj);
                if(!matchingcompetencies.Equals(null))
                {
                    MatchingCompetencies.Add(matchingcompetencies);
                }
                var differingcomptencies = await _compareService.GetDifferingCompetenciesByTypeId(competencytype.Id, positionid, obj);
                if (!differingcomptencies.Equals(null))
                {
                    DifferingCompetencies.Add(differingcomptencies);
                }
            }
        
        }
    }
}