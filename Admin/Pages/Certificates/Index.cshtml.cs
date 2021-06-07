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

namespace Admin.Pages.Certificates
{
    public class IndexModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        private readonly JobCompetencyService _jobCompetencyService;

        public IndexModel(DataModel.CctDbContext context, JobCompetencyService jobCompetencyService)
        {
            _context = context;
            _jobCompetencyService = jobCompetencyService;
        }
        public string CurrentFilter { get; set; }

        public IList<JobCertificateDto> Certificates { get; set; }

        public async Task OnGetAsync(string searchString)
        {
            Certificates = await _jobCompetencyService.GetJobCertificates();
        }
    }
}
