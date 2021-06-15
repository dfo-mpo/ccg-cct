using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Admin.Data;
using Business.Dtos.JobCompetencies;

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
        public string CurrentFilter { get; set; }

        public IList<JobCertificateDto> Certificates { get; set; }

        public async Task OnGetAsync(string searchString)
        {
            Certificates = await _jobCertificateService.GetAllJobCertificateDescriptions();
        }
    }
}
