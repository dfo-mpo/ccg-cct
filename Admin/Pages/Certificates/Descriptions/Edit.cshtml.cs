using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataModel;
using Microsoft.Extensions.Logging;
using Admin.Data;
using System.Linq;
using System.Threading;
using System;

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

        private string CheckUniqueCertificateDescription(CertificateDescription description, bool checkEnglish = true)
        {
            if (description == null)
            {
                return null;
            }

            var desc = description;

            var activeDescs = _context.CertificateDescriptions.Where(x => x.Id != desc.Id && x.Active == 1).ToList();
            var inactiveDescs = _context.CertificateDescriptions.Where(x => x.Id != desc.Id && x.Active == 0).ToList();

            if (checkEnglish)
            {
                if (!string.IsNullOrWhiteSpace(desc.DescEng))
                {
                    if (activeDescs.Select(x => x.DescEng.ToLowerInvariant()).Contains(desc.DescEng.ToLowerInvariant()))
                    {
                        return "That English certificate description already exists";
                    }
                    else if (inactiveDescs.Select(x => x.DescEng.ToLowerInvariant()).Contains(desc.DescEng.ToLowerInvariant()))
                    {
                        return "That English certificate description already exists, but it was deleted. " +
                            "If you wish to enable it once again, contact technical support";
                    }
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(desc.DescFre))
                {
                    if (activeDescs.Select(x => x.DescFre.ToLowerInvariant()).Contains(desc.DescFre.ToLowerInvariant()))
                    {
                        return "That French certificate description already exists";
                    }
                    else if (inactiveDescs.Select(x => x.DescFre.ToLowerInvariant()).Contains(desc.DescFre.ToLowerInvariant()))
                    {
                        return "That French certificate description already exists, but it was deleted. " +
                            "If you wish to enable it once again, contact technical support";
                    }
                }
            }

            return null;
        }

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
            var errEng = CheckUniqueCertificateDescription(Certificate);
            if (errEng != null)
            {
                ModelState.AddModelError("Certificate.DescEng", errEng);
            }
            var errFre = CheckUniqueCertificateDescription(Certificate, false);
            if (errFre != null)
            {
                ModelState.AddModelError("Certificate.DescFre", errFre);
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

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
                await _jobCertificateService.UpdateJobCertificateDescription(Certificate);

                return RedirectToPage("Details", new { id });
            }

            return Page();
        }
    }
}