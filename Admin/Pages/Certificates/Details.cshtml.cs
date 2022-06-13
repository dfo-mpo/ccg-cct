using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Business.Dtos.JobCompetencies;
using Admin.Data;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Pages.Certificates
{
    public class DetailsModel : PageModel
    {
        private readonly JobCertificateService _jobCertificateService;

        public DetailsModel(JobCertificateService jobCertificateService)
        {
            _jobCertificateService = jobCertificateService;
        }

        public JobCertificateDto Certificate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Certificate = await _jobCertificateService.GetJobCertificateById(id.Value);
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
    }
}
