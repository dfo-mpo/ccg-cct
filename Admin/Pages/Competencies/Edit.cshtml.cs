﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Business.Dtos.JobCompetencies;
using Admin.Data;
using Microsoft.Extensions.Logging;
using System.Threading;

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

            try
            {
                Competency.Level1DescEng = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 1).Result.CompetencyLevelReqDescEng;
            }
            catch
            {
                Competency.Level1DescEng = "";
            }
            try
            {
                Competency.Level1DescFre = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 1).Result.CompetencyLevelReqDescFre;
            }
            catch
            {
                Competency.Level1DescFre = "";
            }


            try
            {
                Competency.Level2DescEng = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 2).Result.CompetencyLevelReqDescEng;
            }
            catch
            {
                Competency.Level2DescEng = "";
            }
            try
            {
                Competency.Level2DescFre = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 2).Result.CompetencyLevelReqDescFre;
            }
            catch
            {
                Competency.Level2DescFre = "";
            }


            try
            {
                Competency.Level3DescEng = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 3).Result.CompetencyLevelReqDescEng;
            }
            catch
            {
                Competency.Level3DescEng = "";
            }
            try
            {
                Competency.Level3DescFre = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 3).Result.CompetencyLevelReqDescFre;
            }
            catch
            {
                Competency.Level3DescFre = "";
            }


            try
            {
                Competency.Level4DescEng = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 4).Result.CompetencyLevelReqDescEng;
            }
            catch
            {
                Competency.Level4DescEng = "";
            }
            try
            {
                Competency.Level4DescFre = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 4).Result.CompetencyLevelReqDescFre;
            }
            catch
            {
                Competency.Level4DescFre = "";
            }


            try
            {
                Competency.Level5DescEng = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 5).Result.CompetencyLevelReqDescEng;
            }
            catch
            {
                Competency.Level5DescEng = "";
            }
            try
            {
                Competency.Level5DescFre = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 5).Result.CompetencyLevelReqDescFre;
            }
            catch
            {
                Competency.Level5DescFre = "";
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

            Thread.Sleep(5000);
            return RedirectToPage("Details", new { id = Competency.Id });
        }

        private bool CompetencyExists(int id)
        {
            return _context.Competencies.Any(e => e.Id == id);
        }
    }
}
