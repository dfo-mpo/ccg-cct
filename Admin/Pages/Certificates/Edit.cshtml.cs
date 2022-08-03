using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Microsoft.Extensions.Logging;
using Admin.Data;
using System.Threading;
using Business.Dtos.JobCompetencies;

namespace Admin.Pages.Certificates
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
        public Certificate Certificate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Certificate = await _context.Certificates.FindAsync(id);
            if (Certificate == null)
            {
                return NotFound();
            }
            if (Certificate.Active != 1)
            {
                return NotFound();
            }
            return Page();
        }

        private string CheckUniqueCertificateName(Certificate certificate, bool checkEnglish = true)
        {
            if (certificate == null)
            {
                return null;
            }

            var cert = certificate;

            var activeCerts = _context.Certificates.Where(x => x.Id != cert.Id && x.Active == 1).ToList();
            var inactiveCerts = _context.Certificates.Where(x => x.Id != cert.Id && x.Active == 0).ToList();

            if (checkEnglish)
            {
                if (!string.IsNullOrWhiteSpace(cert.NameEng))
                {
                    if (activeCerts.Select(x => x.NameEng.ToLowerInvariant()).Contains(cert.NameEng.ToLowerInvariant()))
                    {
                        return "A certificate with the same English title already exists";
                    }
                    else if (inactiveCerts.Select(x => x.NameEng.ToLowerInvariant()).Contains(cert.NameEng.ToLowerInvariant()))
                    {
                        return "A certificate with the same English title already exists, but it was deleted. " +
                            "If you wish to enable it once again, contact technical support";
                    }
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(cert.NameFre))
                {
                    if (activeCerts.Select(x => x.NameFre.ToLowerInvariant()).Contains(cert.NameFre.ToLowerInvariant()))
                    {
                        return "A certificate with the same French title already exists";
                    }
                    else if (inactiveCerts.Select(x => x.NameFre.ToLowerInvariant()).Contains(cert.NameFre.ToLowerInvariant()))
                    {
                        return "A certificate with the same English title already exists, but it was deleted. " +
                            "If you wish to enable it once again, contact technical support";
                    }
                }
            }

            return null;
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int id)
        {
            var errEng = CheckUniqueCertificateName(Certificate);
            if (errEng != null)
            {
                ModelState.AddModelError("Certificate.NameEng", errEng);
            }
            var errFre = CheckUniqueCertificateName(Certificate, false);
            if (errFre != null)
            {
                ModelState.AddModelError("Certificate.NameFre", errFre);
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var certificateToUpdate = await _context.Certificates.FindAsync(id);

            if (certificateToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<Certificate>(
                certificateToUpdate,
                "certificate",
                s => s.NameEng, s => s.NameFre, s => s.DescEng, s => s.DescFre))
            {
                await _jobCertificateService.UpdateJobCertificate(Certificate);

                return RedirectToPage("Details", new { id });
            }

            return Page();
        }
    }
}

