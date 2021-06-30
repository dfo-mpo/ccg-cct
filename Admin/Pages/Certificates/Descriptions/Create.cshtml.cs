using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataModel;
using Admin.Data;
using Business.Dtos.JobCompetencies;
using Microsoft.Extensions.Logging;
using System.Threading;

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

        [BindProperty]
        public int CompetencyType { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            var id = await _jobCertificateService.PostJobCertificateDescription(Certificate.DescEng, Certificate.DescFre);
            Thread.MemoryBarrier();
            return RedirectToPage("Details", new { id });

        }
    }
}