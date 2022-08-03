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
using System.Threading;

namespace Admin.Pages.Positions
{
    public class DeleteModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly ILogger<DeleteModel> _logger;
        private readonly JobPositionService _jobPositionService;

        public DeleteModel(DataModel.CctDbContext context,
            ILogger<DeleteModel> logger, JobPositionService jobPositionService)
        {
            _context = context;
            _logger = logger;
            _jobPositionService = jobPositionService;
        }

        [BindProperty]
        public JobPosition JobPosition { get; set; }
        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JobPosition = await _context.JobPositions
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (JobPosition == null)
            {
                return NotFound();
            }
            if (JobPosition.Active != 1)
            {
                return NotFound();
            }
 
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JobPosition = await _context.JobPositions.FindAsync(id);

            if (JobPosition == null)
            {
                return NotFound();
            }
            if (JobPosition.Active != 1)
            {
                return NotFound();
            }

            await _jobPositionService.DeleteJobPosition(JobPosition);

            return RedirectToPage("./Index");
        }
    }
}
