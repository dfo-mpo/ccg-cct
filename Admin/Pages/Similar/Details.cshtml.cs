using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Admin.Data;
using Microsoft.Extensions.Logging;
using Business.Dtos.JobGroups;
using Business.Dtos.JobPositions;

namespace Admin.Pages.Similar
{
    public class DetailsModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly ILogger<DetailsModel> _logger;
        private readonly JobPositionService _jobPositionService;


        public DetailsModel(DataModel.CctDbContext context,
            ILogger<DetailsModel> logger, JobPositionService jobPositionService)
        {
            _context = context;
            _logger = logger;
            _jobPositionService = jobPositionService;
        }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        [BindProperty]
        public SearchSimilarJob JobPosition { get; set; }
        [BindProperty]
        public JobGroupDto[] JobGroups { get; set; }
        public JobGroupDto CurrentSelectedJobGroup { get; set; }
        public JobGroupPositionDto CurrentSelectedLevelCode { get; set; }
        public JobPositionDto CurrentPosition { get; set; }
        public JobPositionDto CurrentSelectedPosition { get; set; }
        public string CurrentSelectedJobTitleEng { get; set; } = string.Empty;
        public string CurrentSelectedJobTitleFre { get; set; } = string.Empty;
        public JobGroupPositionDto[] JobGroupPositions { get; set; }
        [BindProperty(SupportsGet = true)]
        public int SelectedJobPositionId { get; set; }
        public JobPositionDto[] JobGroupLevelPositions { get; set; } = new JobPositionDto[] { };
        [BindProperty(SupportsGet = true)]
        public int JobGroupId { get; set; } = 2;
        [BindProperty(SupportsGet = true)]
        public int SubJobGroupId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string LevelCode { get; set; }
        [BindProperty(SupportsGet = true)]
        public string LevelValue { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SubGroupCode { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PercentSelection { get; set; }
        [BindProperty(SupportsGet = true)]
        public int JobGroupLevelId { get; set; }
        public JobPositionDto[] AddedOneHundredPercentJobPositions = new JobPositionDto[] { };
        [BindProperty(SupportsGet = true)]
        public string AddedOneHundredPercentIds { get; set; } = string.Empty;
        public JobPositionDto[] AddedNinetyPercentJobPositions = new JobPositionDto[] { };
        [BindProperty(SupportsGet = true)]
        public string AddedNinetyPercentIds { get; set; } = string.Empty;
        public JobPositionDto[] AddedEightyPercentJobPositions = new JobPositionDto[] { };
        [BindProperty(SupportsGet = true)]
        public string AddedEightyPercentIds { get; set; } = string.Empty;
        public JobPositionDto[] AddedSeventyPercentJobPositions = new JobPositionDto[] { };
        [BindProperty(SupportsGet = true)]
        public string AddedSeventyPercentIds { get; set; } = string.Empty;

        public async Task<IActionResult> OnGetAsync(int? id, string? percent)
        {
            if (id == null)
            {
                return NotFound();
            }

            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);

            if (CurrentPosition == null)
            {
                return NotFound();
            }
            if (CurrentPosition.Active != 1)
            {
                return NotFound();
            }

            JobPosition = await _context.SearchSimilarJobs.FirstOrDefaultAsync(m => m.Position == id);

            if (JobPosition == null)
            {
                return Redirect("/Similar/Create?id=" + CurrentPosition.JobTitleId);
            }

            PercentSelection = "100";

            if (percent != null)
            {
                if (percent == "90")
                {
                    PercentSelection = "90";
                }
                else if (percent == "80")
                {
                    PercentSelection = "80";
                }
                else if (percent == "70")
                {
                    PercentSelection = "70";
                }
            }

            AddedOneHundredPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(JobPosition.HundredPercent);
            AddedNinetyPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(JobPosition.NinetyPercent);
            AddedEightyPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(JobPosition.EightyPercent);
            AddedSeventyPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(JobPosition.SeventyPercent);

            return Page();
        }

    }
}