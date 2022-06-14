using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Admin.Data;
using System.Threading;

namespace Admin.Pages.Certificates
{
    public class DeleteModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly ILogger<DeleteModel> _logger;
        private readonly JobCertificateService _jobCertificateService;

        public DeleteModel(DataModel.CctDbContext context,
            ILogger<DeleteModel> logger, JobCertificateService jobCertificateService)
        {
            _context = context;
            _logger = logger;
            _jobCertificateService = jobCertificateService;
        }

        [BindProperty]
        public Certificate Certificate { get; set; }
        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            Certificate = await _context.Certificates
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Certificate == null)
            {
                return NotFound();
            }
            if (Certificate.Active != 1)
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

            var Certificate = await _context.Certificates.FindAsync(id);

            if (Certificate == null)
            {
                return NotFound();
            }

            try
            {
                _jobCertificateService.DeleteJobCertificate(Certificate);
                Thread.Sleep(5000);
                return RedirectToPage("./Index");
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
