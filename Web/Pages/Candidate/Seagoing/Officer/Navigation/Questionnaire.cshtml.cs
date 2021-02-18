using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.Candidate.Seagoing.Officer.Navigation
{
    public class QuestionnaireModel : PageModel
    {
        [BindProperty]
        public List<JobCompetencyRatingDto> Type1Competencies { get; set; } = new List<JobCompetencyRatingDto>();
        [BindProperty(SupportsGet = true)]
        public string Optional { get; set; } = String.Empty;
        [BindProperty(SupportsGet = true)]
        public string Parameters { get; set; } = String.Empty;
        [BindProperty(SupportsGet = true)]
        public string OptionalType2 { get; set; } = String.Empty;
        [BindProperty(SupportsGet = true)]
        public string ParametersType2 { get; set; } = String.Empty;
        [BindProperty(SupportsGet = true)]
        public string OptionalType3 { get; set; } = String.Empty;
        [BindProperty(SupportsGet = true)]
        public string ParametersType3 { get; set; } = String.Empty;
        // [BindProperty(SupportsGet = true)]
        // public string OptionalValue { get; set; } = String.Empty;
        public void OnGet()
        {
            //Parameters += parameters;
        }

        public async Task OnPost()
        {
            Parameters += Optional + '%';
            ParametersType2 += OptionalType2 + '%';
            ParametersType3 += OptionalType3 + '%';
            //foreach(var competency in Optional) { 
            //  var competencyDto = new JobCompetencyRatingDto
            //   {
            //CompetencyNameEng = competency,
            //   };

            //   Type1Competencies.Add(competencyDto);
            //   }
        }
    }
}
