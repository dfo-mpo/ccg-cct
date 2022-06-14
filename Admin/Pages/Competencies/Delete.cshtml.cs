using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Admin.Data;
using Business.Dtos.JobCompetencies;
using System.Threading;

namespace Admin.Pages.Competencies
{
    public class DeleteModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly ILogger<DeleteModel> _logger;
        private readonly JobCompetencyService _jobCompetencyService;

        public DeleteModel(DataModel.CctDbContext context,
            ILogger<DeleteModel> logger, JobCompetencyService jobCompetencyService)
        {
            _context = context;
            _logger = logger;
            _jobCompetencyService = jobCompetencyService;
        }

        [BindProperty]
        public JobCompetencyDto Competency { get; set; }
        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, bool? saveChangesError = false)
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

            if (saveChangesError.GetValueOrDefault())
            {
                ErrorMessage = String.Format("Delete {ID} failed. Try again", id);
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
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
                _jobCompetencyService.DeleteJobCompetency(Competency);
                Thread.Sleep(5000);
                return RedirectToPage("./List", new { typeId = Competency.TypeId });
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, ErrorMessage);

                return RedirectToAction("./Delete",
                                           new { id, saveChangesError = true });
            }
        }
    }
}
