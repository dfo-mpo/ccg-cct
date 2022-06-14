using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Admin.Data;
using Business.Dtos.JobCompetencies;
using System.Threading;

namespace Admin.Pages.Certificates.Descriptions
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
        public CertificateDescription Certificate { get; set; }
        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            Certificate = await _context.CertificateDescriptions.FindAsync(id);

            if (Certificate == null)
            {
                return NotFound();
            }
            if (Certificate.Active != 1)
            {
                return NotFound();
            }

            // the empty certificate description should not be accessible directly from the index page, since it is unique.
            // It shouldn't be mofidied, deleted, or viewed, it should simply be an option to select when adding a certificate to a position
            if (string.IsNullOrWhiteSpace(Certificate.DescEng) && string.IsNullOrWhiteSpace(Certificate.DescFre))
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
                _jobCertificateService.DeleteJobCertificateDescription(Certificate);
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
