using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Admin.Data;
using Business.Dtos.JobCompetencies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

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

        public bool DisplayTopOfPage { get; set; }

        public double LastTableContainerHeight { get; set; } = 300;

        public IList<JobCertificateDto> Descriptions { get; set; }

        public async Task OnGetAsync()
        {
            Descriptions = await _jobCertificateService.GetAllJobCertificateDescriptions();

            DisplayTopOfPage = true;
            var sessionStr = HttpContext.Session.GetString("displayTopOfPage");
            if (!string.IsNullOrEmpty(sessionStr))
            {
                if (sessionStr.ToLower() == "false")
                {
                    DisplayTopOfPage = false;
                }
            }
            sessionStr = HttpContext.Session.GetString("lastTableContainerHeight");
            if (!string.IsNullOrEmpty(sessionStr))
            {
                if (double.TryParse(sessionStr, out double num))
                {
                    if (num > 300)
                    {
                        LastTableContainerHeight = num;
                    }
                }
            }
        }
    }
}
