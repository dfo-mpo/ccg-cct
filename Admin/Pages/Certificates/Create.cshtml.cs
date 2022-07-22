using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Collections.Generic;
using Admin.Data;
using Business.Dtos.JobCompetencies;
using System.Threading;

namespace Admin.Pages.Certificates
{
    public class CreateModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly JobCertificateService _jobCertificateService;

        public CreateModel(DataModel.CctDbContext context, JobCertificateService jobCertificateService)
        {
            _context = context;
            _jobCertificateService = jobCertificateService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JobCertificateDto Certificate { get; set; }

        [BindProperty]
        public int CompetencyType { get; set; }

        private string CheckUniqueCertificateName(JobCertificateDto certificate, bool checkEnglish = true)
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
        public async Task<IActionResult> OnPostAsync()
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

            var id = await _jobCertificateService.PostJobCertificate(Certificate);

            return RedirectToPage("Details", new { id });

        }
    }
}