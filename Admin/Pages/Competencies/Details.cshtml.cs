using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Business.Dtos.JobCompetencies;
using Admin.Data;

namespace Admin.Pages.Competencies
{
    public class DetailsModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        private readonly JobCompetencyService _jobCompetencyService;

        public DetailsModel(DataModel.CctDbContext context, JobCompetencyService jobCompetencyService)
        {
            _context = context;
            _jobCompetencyService = jobCompetencyService;
        }
        public JobCompetencyDto Competency { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compExists = _context.Competencies.Where(x => x.Id == id.Value).FirstOrDefault();

            if (compExists == null)
            {
                return NotFound();
            }
            if (compExists.Active != 1)
            {
                return NotFound();
            }

            Competency = await _jobCompetencyService.GetJobCompetencyById(id);

            if (Competency == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
