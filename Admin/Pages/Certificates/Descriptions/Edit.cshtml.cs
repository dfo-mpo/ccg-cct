using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataModel;
using Microsoft.Extensions.Logging;
using Admin.Data;
using System.Threading;

namespace Admin.Pages.Certificates.Descriptions
{
    public class EditModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly ILogger<EditModel> _logger;
        private readonly JobCertificateService _jobCertificateService;


        public EditModel(DataModel.CctDbContext context,
            ILogger<EditModel> logger, JobCertificateService jobCertificateService)
        {
            _context = context;
            _logger = logger;
            _jobCertificateService = jobCertificateService;
        }

        [BindProperty]
        public CertificateDescription Certificate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
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

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int id)
        {
            var certificateToUpdate = await _context.CertificateDescriptions.FindAsync(id);

            if (certificateToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<CertificateDescription>(
                certificateToUpdate,
                "certificate",
                s => s.DescEng, s => s.DescFre))
            {
                _jobCertificateService.UpdateJobCertificateDescription(Certificate);
                Thread.Sleep(5000);
                return RedirectToPage("Details", new { id });
            }

            return Page();
        }
    }
}