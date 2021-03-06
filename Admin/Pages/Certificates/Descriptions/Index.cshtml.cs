﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Admin.Data;
using Business.Dtos.JobCompetencies;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Pages.Certificates.Descriptions
{
    public class IndexModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        private readonly JobCertificateService _jobCertificateService;

        public IndexModel(DataModel.CctDbContext context, JobCertificateService jobCertificateService)
        {
            _context = context;
            _jobCertificateService = jobCertificateService;
        }
        [BindProperty(SupportsGet = true)]
        public string Filter { get; set; }

        public IList<JobCertificateDto> Descriptions { get; set; }

        public async Task OnGetAsync(string searchString)
        {
            Descriptions = await _jobCertificateService.GetAllJobCertificateDescriptions();
        }
    }
}
