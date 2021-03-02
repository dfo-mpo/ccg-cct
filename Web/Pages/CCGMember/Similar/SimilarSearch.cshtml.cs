﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Business.Dtos.JobPositions;
using Business.Dtos.JobCompetencies;
using System.Collections.Generic;
using System.Linq;

namespace Web.Pages.CCGMember.Similar
{
    public class SimilarSearchModel : PageModel
    {
        private readonly ILogger<SimilarSearchModel> _logger;
        private readonly JobPositionService _jobpositionService;
        [BindProperty]
        public JobPositionDto Position { get; set; }
        [BindProperty(SupportsGet =true)]
        public int PositionId { get; set; }
        public JobCertificateDto[] PositionCertificates { get; set; }
        public JobCompetencyRatingDto[] PositionRatings1 { get; set; }
        public JobCompetencyRatingDto[] PositionRatings2 { get; set; }
        public JobCompetencyRatingDto[] PositionRatings3 { get; set; }
        [BindProperty]
        public List<string> CertificateIds { get; set; } = new List<string>();
        [BindProperty]
        public List<string> SameLevelCompetencyIds { get; set; } = new List<string>();
        [BindProperty]
        public List<string> HigherLevelCompetencyIds { get; set; } = new List<string>();
        [BindProperty(SupportsGet = true)]
        public string Certificates { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string SameLevels { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string HigherLevels { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string SameOrHigherLevels { get; set; } = string.Empty;
        [BindProperty(SupportsGet =true)]
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
            if(!SameLevels.Equals(string.Empty))
            {
                var ids = SameLevels.Split("&sameLevelCompetencyId=");
                foreach(var id in ids)
                {
                    SameLevelCompetencyIds.Add(id);
                }     
            }
            if (!HigherLevels.Equals(string.Empty))
            {
                var ids = HigherLevels.Split("&higherLevelCompetencyId=");
                foreach (var id in ids)
                {
                    HigherLevelCompetencyIds.Add(id);
                }
            }
            if (!SameOrHigherLevels.Equals(string.Empty))
            {
                var ids = SameOrHigherLevels.Split("&sameOrHigherLevelCompetencyId=");
                foreach (var id in ids)
                {
                    HigherLevelCompetencyIds.Add(id);
                    SameLevelCompetencyIds.Add(id);
                }
            }
            if (!Certificates.Equals(string.Empty))
            {
                var ids = Certificates.Split("&certificateId=");
                foreach (var id in ids)
                {
                    CertificateIds.Add(id);
                }
            }
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
            SameLevels = string.Empty;
            HigherLevels = string.Empty;
            SameOrHigherLevels = string.Empty;

            foreach (var c in CertificateIds)
            {
                    Certificates += "&certificateId=" + c;
            }

            foreach (var c in SameLevelCompetencyIds)
            {

                    if (!HigherLevelCompetencyIds.Contains(c))
                    {
                        SameLevels += "&sameLevelCompetencyId=" + c;
                    }
                    else
                    {
                        SameOrHigherLevels += "&sameOrHigherLevelCompetencyId=" + c;
                    }

            }

            foreach (var c in HigherLevelCompetencyIds)
            {
                if (!SameLevelCompetencyIds.Contains(c))
                {
                    HigherLevels += "&higherLevelCompetencyId=" + c;
                }
            }
        }
    }

}