using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Admin.Data;
using Business.Dtos.JobCompetencies;
using System.Threading;

namespace Admin.Pages.Certificates
{
    public class CreateModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly JobCertificateService _jobCertificateService;

        public CreateModel(DataModel.CctDbContext context, JobCertificateService jobCertificateService)
        {
            _context = context;
            _jobCertificateService = jobCertificateService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JobCertificateDto Certificate { get; set; }

        [BindProperty]
        public int CompetencyType { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var Parameters = $"&nameEng={Certificate.NameEng}&nameFre={Certificate.NameFre}&descEng={Certificate.DescEng}&descFre={Certificate.DescFre}"; 
            var id = await _jobCertificateService.PostJobCertificate(Parameters);
            Thread.MemoryBarrier();
            return RedirectToPage("Details", new { id });

        }
    }
}