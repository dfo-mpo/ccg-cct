using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Business.Dtos.JobCompetencies;
using Admin.Data;
namespace Admin.Pages.Certificates.Descriptions
{
    public class DetailsModel : PageModel
    {
        private readonly JobCertificateService _jobCertificateService;

        public DetailsModel(JobCertificateService jobCertificateService)
        {
            _jobCertificateService = jobCertificateService;
        }

        public JobCertificateDto Description { get; set; }

        public async Task OnGetAsync(int id)
        {
            Description = await _jobCertificateService.GetJobCertificateDescriptionById(id);
        }
    }
}