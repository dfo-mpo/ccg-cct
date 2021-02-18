using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.Candidate
{
    public class QuestionnaireModel : PageModel
    {
        public JobCertificateDto[] PositionCertificates { get; set; }
        public JobCompetencyRatingDto[] PositionRatings1 { get; set; } = new JobCompetencyRatingDto[] { };
        public JobCompetencyRatingDto[] PositionRatings2 { get; set; }
        public JobCompetencyRatingDto[] PositionRatings3 { get; set; }
        [BindProperty]
        public List<string> DeckLevels { get; set; } = new List<string>();
        public void OnGet()
        {

        }

        public async Task OnPost()
        {
            var e = DeckLevels[0];
        }
    }
}