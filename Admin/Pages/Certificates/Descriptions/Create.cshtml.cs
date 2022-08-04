using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataModel;
using Admin.Data;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

namespace Admin.Pages.Certificates.Descriptions
{
    public class CreateModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly ILogger<CreateModel> _logger;
        private readonly JobCertificateService _jobCertificateService;


        public CreateModel(DataModel.CctDbContext context,
            ILogger<CreateModel> logger, JobCertificateService jobCertificateService)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
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

            var id = await _jobCertificateService.PostJobCertificateDescription(Certificate);
            return RedirectToPage("Details", new { id });

        }
    }
}