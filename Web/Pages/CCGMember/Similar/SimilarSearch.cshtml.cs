﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Business.Dtos.JobPositions;
using Business.Dtos.JobCompetencies;
using System.Collections.Generic;

namespace Web.Pages.CCGMember.Similar
{
    public class SimilarSearchModel : PageModel
    {
        private readonly ILogger<SimilarSearchModel> _logger;
        private readonly JobPositionService _jobpositionService;
        [BindProperty]
        public JobPositionDto Position { get; set; }
        public JobCertificateDto[] PositionCertificates { get; set; }
        public JobCompetencyRatingDto[] PositionRatings1 { get; set; }
        public JobCompetencyRatingDto[] PositionRatings2 { get; set; }
        public JobCompetencyRatingDto[] PositionRatings3 { get; set; } 
        [BindProperty]
        public List<string> SameLevelCompetencyIds { get; set; } = new List<string>();
        [BindProperty]
        public List<string> HigherLevelCompetencyIds { get; set; } = new List<string>();
        [BindProperty]
        public string SameLevels { get; set; } = string.Empty;
        [BindProperty]
        public string HigherLevels { get; set; } = string.Empty;
        [BindProperty]
        public string RouteParameter { get; set; } = string.Empty;
        [BindProperty]
        public Boolean PageSubmit { get; set; } = false;
        [BindProperty]
        public string GroupId { get; set; }
        [BindProperty]
        public string GroupLevelId { get; set; }
        public SimilarSearchModel(ILogger<SimilarSearchModel> logger, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGetAsync(int positionid)
        {
            _logger.LogInformation($"Similar Position Search page visited at {DateTime.UtcNow.ToLongTimeString()}");
            Position = await _jobpositionService.GetJobPositionById(positionid);
            GroupId = Position.JobGroupId.ToString();
            GroupLevelId = Position.JobGroupLevelId.ToString();
            PositionCertificates = await _jobpositionService.GetJobCertificatesById(positionid);
            PositionRatings1 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(positionid, 1);
            PositionRatings2 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(positionid, 2);
            PositionRatings3 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(positionid, 3);
        }
        public async Task OnPost(int positionid)
        {
            Position = await _jobpositionService.GetJobPositionById(positionid);
            PageSubmit = true;
            //public IActionResult OnPost(int positionid){ 
            foreach (var c in SameLevelCompetencyIds)
            {
                SameLevels += "&sameLevels=" + c;
            }

            foreach (var c in HigherLevelCompetencyIds)
            {
                HigherLevels += "&higherLevels=" + c;
            }

            RouteParameter = "jobPositionId="+positionid.ToString() +"&jobGroupLevelId="+Position.JobGroupLevelId.ToString()
                +"&jobGroupId="+Position.JobGroupId.ToString() +SameLevels + HigherLevels;

            //return RedirectToPage("SimilarList", new { id = routedata }); // not working
        }
    }

}