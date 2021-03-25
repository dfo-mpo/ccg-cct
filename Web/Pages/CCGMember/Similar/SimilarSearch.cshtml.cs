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
        [BindProperty(SupportsGet =true)]
        public int PositionId { get; set; }
        public JobCertificateDto[] PositionCertificates { get; set; }
        [BindProperty]
        public List<JobCompetencyRatingDto[]> PositionCompetencyRatings { get; set; } = new List<JobCompetencyRatingDto[]>();
        [BindProperty]
        public List<string> CertificateIds { get; set; } = new List<string>();
        [BindProperty]
        public List<string> SameLevelCompetencyIds { get; set; } = new List<string>();
        [BindProperty]
        public List<string> HigherLevelCompetencyIds { get; set; } = new List<string>();
        [BindProperty]
        public List<string> RequiredCompetencyIds { get; set; } = new List<string>();
        [BindProperty(SupportsGet = true)]
        public string Certificates { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string SameLevels { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string HigherLevels { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string SameOrHigherLevels { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPageSimilar { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPage { get; set; } = string.Empty;
        [BindProperty(SupportsGet =true)]
        public Boolean PageEdit { get; set; } = false;
        [BindProperty(SupportsGet = true)]
        public Boolean PageSubmit { get; set; } = false;
        [BindProperty(SupportsGet =true)]
        public string Id { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string Level { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string AddedCompetencies { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public List<int> PositionCompetencyValues { get; set; } = new List<int>();
        [BindProperty]
        public List<int> AddedCompetencyValues { get; set; } = new List<int>();
        public SimilarSearchModel(ILogger<SimilarSearchModel> logger, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGetAsync(int positionid)
        {
            _logger.LogInformation($"Similar Position Search page visited at {DateTime.UtcNow.ToLongTimeString()}");
            if (!SameLevels.Equals(string.Empty))
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
            foreach (var added in AddedCompetencies.Split("&addedCompetencyId="))
            {
                if (!string.IsNullOrEmpty(added))
                {
                    int number;
                    bool success = Int32.TryParse(added, out number);
                    if (success)
                    {
                        AddedCompetencyValues.Add(number);
                    }

                }
            }
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
        public async Task OnPost(int positionid)
        { 
            Position = await _jobpositionService.GetJobPositionById(positionid);
            PositionId = positionid;
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
        public void OnPostCompetency(string competencyid)
        {

            PageSubmit = true;
            PageEdit = true;
            AddedCompetencies += "&addedCompetencyId=" + competencyid;

            foreach (var added in AddedCompetencies.Split("&addedCompetencyId="))
            {
                if (!string.IsNullOrEmpty(added))
                {
                    int number;
                    bool success = Int32.TryParse(added, out number);
                    if (success)
                    {
                        AddedCompetencyValues.Add(number);

                    }

                }
            }

        }
        public void OnPostDelete(int competencyid)
        {

            PageSubmit = true;
            PageEdit = true;
            foreach (var added in AddedCompetencies.Split("&addedCompetencyId="))
            {
                if (!string.IsNullOrEmpty(added))
                {
                    int number;
                    bool success = Int32.TryParse(added, out number);
                    if (success)
                    {
                        AddedCompetencyValues.Add(number);
                    }
                }
            }
            AddedCompetencyValues.Remove(competencyid);
            AddedCompetencies = string.Empty;
            foreach (var id in AddedCompetencyValues)
            {
                AddedCompetencies += "&addedCompetencyId=" + id.ToString();
            }
        }
        public async Task OnPostEdit(int positionid)
        {
            Position = await _jobpositionService.GetJobPositionById(positionid);
            PositionId = positionid;
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
            PageSubmit = true;
            PageEdit = true;
            Position = await _jobpositionService.GetJobPositionById(positionid);
            var CompetencyTypes = await _jobpositionService.GetAllJobCompetencyTypes();
            foreach (var competencytype in CompetencyTypes)
            {
                var competencies = await _jobpositionService.GetJobCompetencyRatingsByTypeId(positionid, competencytype.Id);
                if (!competencies.Equals(null))
                {
                    PositionCompetencyRatings.Add(competencies);
                }
            }
            foreach (var c in PositionCompetencyRatings)
            {
                foreach (var r in c)
                {
                    PositionCompetencyValues.Add(r.CompetencyId);
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
                        AddedCompetencyValues.Add(number);

                    }

                }
            }

        }

    }

}