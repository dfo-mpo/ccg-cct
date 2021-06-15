using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Business.Dtos.JobCompetencies;
using Admin.Data;
using Microsoft.Extensions.Logging;

namespace Admin.Pages.Competencies
{
    public class EditModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly ILogger<EditModel> _logger;
        private readonly JobCompetencyService _jobCompetencyService;

        public EditModel(DataModel.CctDbContext context,
            ILogger<EditModel> logger, JobCompetencyService jobCompetencyService)
        {
            _context = context;
            _logger = logger;
            _jobCompetencyService = jobCompetencyService;
        }

        [BindProperty]
        public JobCompetencyDto Competency { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Competency = await _context.Competencies.FirstOrDefaultAsync(m => m.Id == id);
            Competency = await _jobCompetencyService.GetJobCompetencyById(id);

            Competency.Level1DescEng = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 1).Result.CompetencyLevelReqDescEng;
            Competency.Level1DescFre = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 1).Result.CompetencyLevelReqDescFre;

            Competency.Level2DescEng = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 2).Result.CompetencyLevelReqDescEng;
            Competency.Level2DescFre = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 2).Result.CompetencyLevelReqDescFre;

            Competency.Level3DescEng = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 3).Result.CompetencyLevelReqDescEng;
            Competency.Level3DescFre = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 3).Result.CompetencyLevelReqDescFre;

            Competency.Level4DescEng = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 4).Result.CompetencyLevelReqDescEng;
            Competency.Level4DescFre = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 4).Result.CompetencyLevelReqDescFre;

            Competency.Level5DescEng = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 5).Result.CompetencyLevelReqDescEng;
            Competency.Level5DescFre = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 5).Result.CompetencyLevelReqDescFre;
            if (Competency == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // _context.Attach(Competency).State = EntityState.Modified;

            try
            {
                _jobCompetencyService.UpdateJobCompetency(Competency);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompetencyExists(Competency.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CompetencyExists(int id)
        {
            return _context.Competencies.Any(e => e.Id == id);
        }
    }
}
