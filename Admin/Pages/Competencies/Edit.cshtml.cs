using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Business.Dtos.JobCompetencies;
using Admin.Data;
using Microsoft.Extensions.Logging;
using System.Threading;

namespace Admin.Pages.Competencies
{
    public class EditModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly ILogger<EditModel> _logger;
        private readonly JobCompetencyService _jobCompetencyService;

        public EditModel(DataModel.CctDbContext context,
            ILogger<EditModel> logger, JobCompetencyService jobCompetencyService)
        {
            _context = context;
            _logger = logger;
            _jobCompetencyService = jobCompetencyService;
        }

        [BindProperty]
        public JobCompetencyDto Competency { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compExists = _context.Competencies.Where(x => x.Id == id.Value).FirstOrDefault();

            if (compExists == null)
            {
                return NotFound();
            }
            if (compExists.Active != 1)
            {
                return NotFound();
            }

            Competency = await _jobCompetencyService.GetJobCompetencyById(id);
            if (Competency == null)
            {
                return NotFound();
            }

            return Page();
        }

        private string CheckUniqueCompetencyName(JobCompetencyDto competency, bool checkEnglish = true)
        {
            if (competency == null)
            {
                return null;
            }

            var comp = competency;

            var compTypeName = _context.CompetencyTypes.Where(x => x.Id == comp.TypeId).FirstOrDefault().NameEng.ToLower();
            if (compTypeName.Contains("ies"))
            {
                compTypeName = compTypeName.Replace("ies", "yX");
            }
            compTypeName = compTypeName[..^1];

            var competencyIdsOfType = _context.CompetencyTypeGroups.Where(x => x.CompetencyTypeId == comp.TypeId)
              .Select(x => x.CompetencyId).ToList();

            var activeComps = _context.Competencies.Where(x => x.Id != comp.Id && competencyIdsOfType.Contains(x.Id) && x.Active == 1).ToList();
            var inactiveComps = _context.Competencies.Where(x => x.Id != comp.Id && competencyIdsOfType.Contains(x.Id) && x.Active == 0).ToList();

            if (checkEnglish)
            {
                if (!string.IsNullOrWhiteSpace(comp.NameEng))
                {
                    if (activeComps.Select(x => x.NameEng.ToLowerInvariant()).Contains(comp.NameEng.ToLowerInvariant()))
                    {
                        return "There is already a" + (compTypeName[0] == 'e' ? "n " : " ") + compTypeName + " with that English name";
                    }
                    else if (inactiveComps.Select(x => x.NameEng.ToLowerInvariant()).Contains(comp.NameEng.ToLowerInvariant()))
                    {
                        return "There is already a" + (compTypeName[0] == 'e' ? "n " : " ") + compTypeName + " with that English name, but it was deleted. " +
                            "If you wish to enable it once again, contact technical support";
                    }
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(comp.NameFre))
                {
                    if (activeComps.Select(x => x.NameFre.ToLowerInvariant()).Contains(comp.NameFre.ToLowerInvariant()))
                    {
                        return "There is already a" + (compTypeName[0] == 'e' ? "n " : " ") + compTypeName + " with that French name";
                    }
                    else if (inactiveComps.Select(x => x.NameFre.ToLowerInvariant()).Contains(comp.NameFre.ToLowerInvariant()))
                    {
                        return "There is already a" + (compTypeName[0] == 'e' ? "n " : " ") + compTypeName + " with that French name, but it was deleted. " +
                            "If you wish to enable it once again, contact technical support";
                    }
                }
            }

            return null;
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            Competency.TypeNameEng = (await _context.CompetencyTypes.Where(x => x.Id == Competency.TypeId).FirstOrDefaultAsync()).NameEng;
            Competency.TypeNameFre = (await _context.CompetencyTypes.Where(x => x.Id == Competency.TypeId).FirstOrDefaultAsync()).NameFre;

            var errEng = CheckUniqueCompetencyName(Competency);
            if (errEng != null)
            {
                ModelState.AddModelError("Competency.NameEng", errEng);
            }
            var errFre = CheckUniqueCompetencyName(Competency, false);
            if (errFre != null)
            {
                ModelState.AddModelError("Competency.NameFre", errFre);
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _jobCompetencyService.UpdateJobCompetency(Competency);

            return RedirectToPage("Details", new { id = Competency.Id });
        }

    }
}
