using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Admin.Data;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Microsoft.AspNetCore.Http;
using Business.Dtos.JobCompetencies;

namespace Admin.Pages.Competencies
{
    public class LocateModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        private readonly JobPositionService _jobPositionService;
        private readonly JobCompetencyService _jobCompetencyService;

        public LocateModel(DataModel.CctDbContext context, JobPositionService jobPositionService, JobCompetencyService jobCompetencyService)
        {
            _context = context;
            _jobPositionService = jobPositionService;
            _jobCompetencyService = jobCompetencyService;
        }
        [BindProperty(SupportsGet = true)]
        public string Filter { get; set; }
        public JobCompetencyDto[] Competencies { get; set; }
        public JobCompetencyTypeDto Type { get; set; }

        public bool DisplayTopOfPage { get; set; }

        public double LastTableContainerHeight { get; set; } = 300;

        public bool LocatingACompetency { get; set; } = false;

        public JobCompetencyDto CompetencyBeingLocated { get; set; }

        public List<CompetencyRatingLevel> RatingLevels { get; set; }

        public Dictionary<JobPositionDto, JobCompetencyRatingDto> PositionsThatHaveTheCompetency { get; set; }

        private async Task PrepareNonLocatePage(int typeId)
        {
            var accepetedTypeIds = _context.CompetencyTypes.Select(c => c.Id).ToList();

            if (!accepetedTypeIds.Contains(typeId))
            {
                Type = await _jobCompetencyService.GetJobCompetencyTypeById(1);
                Competencies = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            }
            else
            {
                Type = await _jobCompetencyService.GetJobCompetencyTypeById(typeId);
                Competencies = await _jobCompetencyService.GetJobCompetenciesByTypeId(typeId);
            }

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

        public async Task<IActionResult> OnGetAsync(int? id, int typeId)
        {
            if (id != null)
            {
                try
                {
                    CompetencyBeingLocated = await _jobCompetencyService.GetJobCompetencyById(id);
                }
                catch
                {
                    CompetencyBeingLocated = null;
                }

                if (CompetencyBeingLocated != null)
                {
                    if (CompetencyBeingLocated.Active == 1)
                    {
                        LocatingACompetency = true;
                    }
                }
            }

            if (!LocatingACompetency)
            {
                await PrepareNonLocatePage(typeId);
            }
            else
            {
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

                Type = await _jobCompetencyService.GetJobCompetencyTypeById(CompetencyBeingLocated.TypeId);
                Competencies = await _jobCompetencyService.GetJobCompetenciesByTypeId(Type.Id);

                RatingLevels = await _context.CompetencyRatingLevels.ToListAsync();

                var activePositions = (await _jobPositionService.GetAllJobPositions()).Where(x => x.Active == 1).ToList();
                int idToFind = id.Value;

                PositionsThatHaveTheCompetency = new Dictionary<JobPositionDto, JobCompetencyRatingDto>();

                foreach (var pos in activePositions)
                {
                    var jobCompetenciesOfType = await _jobCompetencyService.GetJobCompetencyRatingsByTypeId(pos.JobTitleId, Type.Id);

                    foreach (var comp in jobCompetenciesOfType)
                    {
                        if (comp.CompetencyId == idToFind)
                        {
                            PositionsThatHaveTheCompetency.Add(pos, comp);
                            break;
                        }
                    }
                }
            }

            return Page();
        }

        public async Task OnPostAsync(int typeId)
        {
            await PrepareNonLocatePage(typeId);
        }

    }
}
