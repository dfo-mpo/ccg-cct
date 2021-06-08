using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataModel;
using Admin.Data;
using Business.Dtos.JobCompetencies;

namespace Admin.Pages.Competencies
{
    public class CreateModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly JobCompetencyService _jobCompetencyService;

        public CreateModel(DataModel.CctDbContext context, JobCompetencyService jobCompetencyService)
        {
            _context = context;
            _jobCompetencyService = jobCompetencyService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JobCompetencyDto Competency { get; set; }

        [BindProperty]
        public int CompetencyType { get; set; } 

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            Competency.TypeId = CompetencyType;
            _jobCompetencyService.PostJobCompetency(Competency);

            return RedirectToPage("Index");

        }
    }
}