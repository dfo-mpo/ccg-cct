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
        public JobPositionDto CurrentPosition { get; set; }
        public JobPositionDto ObjectivePosition { get; set; }
        [BindProperty]
        public SharedJobCompetencyRating[] MatchingCompetenciesType1 { get; set; }
        [BindProperty]
        public SharedJobCompetencyRating[] DifferingCompetenciesType1 { get; set; }
        [BindProperty]
        public SharedJobCompetencyRating[] MatchingCompetenciesType2 { get; set; }
        [BindProperty]
        public SharedJobCompetencyRating[] DifferingCompetenciesType2 { get; set; }
        [BindProperty]
        public SharedJobCompetencyRating[] MatchingCompetenciesType3 { get; set; }
        [BindProperty]
        public SharedJobCompetencyRating[] DifferingCompetenciesType3 { get; set; }
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

            MatchingCompetenciesType1 = await _compareService.GetMatchingCompetenciesByTypeId(1, positionid, obj);
            MatchingCompetenciesType2 = await _compareService.GetMatchingCompetenciesByTypeId(2, positionid, obj);
            MatchingCompetenciesType3 = await _compareService.GetMatchingCompetenciesByTypeId(3, positionid, obj);

            DifferingCompetenciesType1 = await _compareService.GetDifferingCompetenciesByTypeId(1, positionid, obj);
            DifferingCompetenciesType2 = await _compareService.GetDifferingCompetenciesByTypeId(2, positionid, obj);
            DifferingCompetenciesType3 = await _compareService.GetDifferingCompetenciesByTypeId(3, positionid, obj);

            MatchingCertificates = await _compareService.GetMatchingCertificatesByPositionId(positionid, obj);
            DifferingCertificates = await _compareService.GetMatchingCertificatesByPositionId(positionid, obj);
        }
    }
}