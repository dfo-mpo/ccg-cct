using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Admin.Data;
using Business.Dtos.JobCompetencies;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

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

        public IActionResult OnGet(int? typeid)
        {
            if (typeid == null)
            {
                return Redirect("/Competencies/Create?typeid=1");
            }
            else
            {
                var accepetedTypeIds = _context.CompetencyTypes.Select(c => c.Id).ToList();
                if (!accepetedTypeIds.Contains(typeid.Value))
                {
                    return Redirect("/Competencies/Create?typeid=1");
                }
            }

            return Page();
        }

        [BindProperty]
        public JobCompetencyDto Competency { get; set; }
        [BindProperty(SupportsGet = true)]
        public int TypeId { get; set; }

        [BindProperty]
        public int CompetencyType { get; set; }

        private string CheckUniqueCompetencyName(JobCompetencyDto competency, int typeId, bool checkEnglish = true)
        {
            if (competency == null)
            {
                return null;
            }

            var comp = competency;

            var compTypeName = _context.CompetencyTypes.Where(x => x.Id == typeId).FirstOrDefault().NameEng.ToLower();
            if (compTypeName.Contains("ies"))
            {
                compTypeName = compTypeName.Replace("ies", "yX");
            }
            compTypeName = compTypeName[..^1];

            var competencyIdsOfType = _context.CompetencyTypeGroups.Where(x => x.CompetencyTypeId == typeId)
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
            var errEng = CheckUniqueCompetencyName(Competency, TypeId);
            if (errEng != null)
            {
                ModelState.AddModelError("Competency.NameEng", errEng);
            }
            var errFre = CheckUniqueCompetencyName(Competency, TypeId,false);
            if (errFre != null)
            {
                ModelState.AddModelError("Competency.NameFre", errFre);
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            Competency.TypeId = TypeId;
            var competencyid = await _jobCompetencyService.PostJobCompetency(Competency);

            return RedirectToPage("Details", new { id = competencyid});

        }
    }
}