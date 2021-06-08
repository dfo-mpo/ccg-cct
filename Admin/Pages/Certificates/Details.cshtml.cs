using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Business.Dtos.JobCompetencies;
using Admin.Data;

namespace Admin.Pages.Certificates
{
    public class DetailsModel : PageModel
    {
        //private readonly DataModel.CctDbContext _context;

        private readonly JobCompetencyService _jobpositionService;

        public DetailsModel(JobCompetencyService jobcompetencyService)
        {
            _jobpositionService = jobcompetencyService;
        }

        public JobCertificateDto Certificate { get; set; }

        public async Task OnGetAsync(int id)
        {


            Certificate = await _jobpositionService.GetJobCertificateById(id);

    
        }
    }
}
