using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataModel;
using Business.Dtos.JobCompetencies;
using Microsoft.Extensions.Logging;
using Admin.Data;
using System.Threading;

namespace Admin.Pages.Certificates.Descriptions
{
    public class DetailsModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly ILogger<EditModel> _logger;
        private readonly JobCertificateService _jobCertificateService;

        public DetailsModel(CctDbContext context, ILogger<EditModel> logger, JobCertificateService jobCertificateService)
        {
            _context = context;
            _logger = logger;
            _jobCertificateService = jobCertificateService;
        }

        public CertificateDescription Description { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Description = await _context.CertificateDescriptions.FindAsync(id);
            if (Description == null)
            {
                return NotFound();
            }
            if (Description.Active != 1)
            {
                return NotFound();
            }

            // this is debatable, but I've made it so you can't view/edit/delete the description that is empty, since it is kind of unique
            if (string.IsNullOrWhiteSpace(Description.DescEng) && string.IsNullOrWhiteSpace(Description.DescFre))
            {
                return NotFound();
            }

            return Page();
        }
    }
}