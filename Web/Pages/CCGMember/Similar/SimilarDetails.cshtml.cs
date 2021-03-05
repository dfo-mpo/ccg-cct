﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobPositions;
using Business.Dtos.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Rotativa.AspNetCore;
using Web.Data;

namespace Web.Pages.CCGMember.Similar
{
    public class SimilarDetailsModel : PageModel
    {
        private readonly ILogger<SimilarDetailsModel> _logger;
        private readonly JobPositionService _jobpositionService;
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        [BindProperty(SupportsGet = true)]
        public int ObjectiveId { get; set; }
        public JobPositionDto Position { get; set; }
        public JobCertificateDto[] PositionCertificates { get; set; }
        [BindProperty]
        public List<JobCompetencyRatingDto[]> PositionCompetencyRatings { get; set; } = new List<JobCompetencyRatingDto[]>();
        [BindProperty(SupportsGet = true)]
        public string PercentMatch { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SameLevels { get; set; }
        [BindProperty(SupportsGet = true)]
        public string HigherLevels { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SameOrHigherLevels { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Certificates { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PreviousPage { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PreviousPageSimilar { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPageDetails { get; set; }
        public SimilarDetailsModel(ILogger<SimilarDetailsModel> logger, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGetAsync(int objectiveid)
        {
            _logger.LogInformation($"Position details page visited at {DateTime.UtcNow.ToLongTimeString()}");
            Position = await _jobpositionService.GetJobPositionById(objectiveid);
            PositionCertificates = await _jobpositionService.GetJobCertificatesById(objectiveid);
            var CompetencyTypes = await _jobpositionService.GetAllJobCompetencyTypes();
            foreach (var competencytype in CompetencyTypes)
            {
                var competencies = await _jobpositionService.GetJobCompetencyRatingsByTypeId(objectiveid, competencytype.Id);
                if (!competencies.Equals(null))
                {
                    PositionCompetencyRatings.Add(competencies);
                }
            }
        }
    }
}