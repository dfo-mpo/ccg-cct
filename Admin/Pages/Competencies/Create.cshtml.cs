using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Admin.Data;
using Business.Dtos.JobCompetencies;
using System.Threading;

namespace Admin.Pages.Competencies
{
    public class CreateModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly JobCompetencyService _jobCompetencyService;

        public CreateModel(DataModel.CctDbContext context, JobCompetencyService jobCompetencyService)
        {
            _context = context;
            _jobCompetencyService = jobCompetencyService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JobCompetencyDto Competency { get; set; }
        [BindProperty(SupportsGet = true)]
        public int TypeId { get; set; } = 1;

        [BindProperty]
        public int CompetencyType { get; set; } 

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            Competency.TypeId = CompetencyType;
            var parameters = string.Format($"&typeId={Competency.TypeId}&nameEng={Competency.NameEng}&nameFre={Competency.NameFre}&descEng={Competency.DescEng}&descFre={Competency.DescFre}&level1DescEng={Competency.Level1DescEng}&level1DescFre={Competency.Level1DescFre}&level2DescEng={Competency.Level2DescEng}&level2DescFre={Competency.Level2DescFre}&level3DescEng={Competency.Level3DescEng}&level3DescFre={Competency.Level3DescFre}&level4DescEng={Competency.Level4DescEng}&level4DescFre={Competency.Level4DescFre}&level5DescEng={Competency.Level5DescEng}&level5DescFre={Competency.Level5DescFre}");
            var competencyid = await _jobCompetencyService.PostJobCompetency(parameters);
            Thread.Sleep(5000);
            return RedirectToPage("Details", new { id = competencyid});

        }
    }
}