using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.CCGMember
{
    public class AddCompetenciesModel : PageModel
    {
        private readonly ILogger<AddCompetenciesModel> _logger;
        private readonly JobPositionService _jobpositionService;
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Level { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string Certificates { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string SameLevels { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string HigherLevels { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string SameOrHigherLevels { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public List<int> AddedCompetencyValues { get; set; } = new List<int>();
        [BindProperty(SupportsGet = true)]
        public List<int> PositionCompetencyValues { get; set; } = new List<int>();
        [BindProperty(SupportsGet = true)]
        public string AddedCompetencies { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string CompetencyId { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPageSimilar { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPageDetails { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPage { get; set; } = string.Empty;
        [BindProperty]
        public JobPositionDto Position { get; set; }
        [BindProperty]
        public List<JobCompetencyRatingDto[]> PositionCompetencyRatings { get; set; } = new List<JobCompetencyRatingDto[]>();
        public AddCompetenciesModel(ILogger<AddCompetenciesModel> logger, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGetAsync(int positionid)
        {
            _logger.LogInformation($"Add Competencies page visited at {DateTime.UtcNow.ToLongTimeString()}");
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
            foreach(var c in PositionCompetencyRatings)
            {
                foreach(var r in c) {
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

        public void OnPostCompetency(string competencyid)
        {
            AddedCompetencies += "&addedCompetencyId="+competencyid ;

            foreach(var added in AddedCompetencies.Split("&addedCompetencyId="))
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
            foreach(var id in AddedCompetencyValues)
            {
                AddedCompetencies += "&addedCompetencyId=" + id.ToString();
            }
        } 
    }
}