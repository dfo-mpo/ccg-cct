﻿using System;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Business.Dtos.Similar;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.CCGMember.Similar
{
    public class SimilarListModel : PageModel
    {
        private readonly ILogger<SimilarListModel> _logger;
        private readonly SimilarService _similarService;
        [BindProperty(SupportsGet = true)]

        public int PositionId { get; set; }
        [BindProperty]
        public string RouteParameter { get; set; }
        public JobPositionDto Position { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public int HLId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Level { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string SubGroupCode { get; set; }
        [BindProperty(SupportsGet = true)]
        public string LevelCode { get; set; }
        [BindProperty(SupportsGet = true)]
        public string LevelObj { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PercentMatch { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SameLevels { get; set; }
        [BindProperty(SupportsGet = true)]
        public string HigherLevels { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SameOrHigherLevels { get; set; }
        [BindProperty(SupportsGet = true)]
        public string AddedCompetencies { get; set; }
        [BindProperty(SupportsGet = true)]
        public string RequiredCompetencies { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string Certificates { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PreviousPage { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPageSimilar { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPageDetails { get; set; } = string.Empty;
        public JobPositionDto CurrentPosition { get; set; }
        public SimilarSearchDto SimilarJobIds100 { get; set; }
        public SimilarSearchDto SimilarJobIds90 { get; set; }
        public SimilarSearchDto SimilarJobIds80 { get; set; }
        public SimilarSearchDto SimilarJobIds70 { get; set; }
        public JobPositionDto[] HundredPercentPositions { get; set; } = new JobPositionDto[] { };
        public JobPositionDto[] NinetyPercentPositions { get; set; } = new JobPositionDto[] { };
        public JobPositionDto[] EightyPercentPositions { get; set; } = new JobPositionDto[] { };
        public JobPositionDto[] SeventyPercentPositions { get; set; } = new JobPositionDto[] { };
        public string PageSubmit { get; set; } = string.Empty;
        public SimilarListModel(ILogger<SimilarListModel> logger, SimilarService similarService)
        {
            _logger = logger;
            _similarService = similarService;
        }
        public async Task OnGet(int positionid)
        {
            _logger.LogInformation($"Similar positions list page visited at {DateTime.UtcNow.ToLongTimeString()}");
            CurrentPosition = await _similarService.GetJobPositionById(positionid);
            Position = await _similarService.GetJobPositionById(PositionId);
            RouteParameter = String.Format($"jobPositionId={positionid}{RequiredCompetencies}{SameLevels}{HigherLevels}{SameOrHigherLevels}{AddedCompetencies}{Certificates}{PercentMatch}");
            if (PercentMatch == "&percentMatch=100")
            {
                SimilarJobIds100 = await _similarService.GetAllHundredPercentSimilarPositionsByPositionId(positionid);
                HundredPercentPositions = await _similarService.GetAllSimilarJobPositionsByPositionId($"{RouteParameter}&{SimilarJobIds100?.SimilarPositionIds}");
            }
            else if (PercentMatch == "&percentMatch=90")
            {
                SimilarJobIds90 = await _similarService.GetAllNinetyPercentSimilarPositionsByPositionId(positionid);
                NinetyPercentPositions = await _similarService.GetAllSimilarJobPositionsByPositionId($"{RouteParameter}&{SimilarJobIds90?.SimilarPositionIds}");
            }
            else if (PercentMatch == "&percentMatch=80")
            {
                SimilarJobIds80 = await _similarService.GetAllEightyPercentSimilarPositionsByPositionId(positionid);
                EightyPercentPositions = await _similarService.GetAllSimilarJobPositionsByPositionId($"{RouteParameter}&{SimilarJobIds80?.SimilarPositionIds}");
            }
            else
            {
                SimilarJobIds70 = await _similarService.GetAllSeventyPercentSimilarPositionsByPositionId(positionid);
                SeventyPercentPositions = await _similarService.GetAllSimilarJobPositionsByPositionId($"{RouteParameter}&{SimilarJobIds70?.SimilarPositionIds}");

            }
        }
    }
}