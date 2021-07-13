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

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            PercentSelection = "100";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);

            if (id == null)
            {
                return NotFound();
            }

            JobPosition = await _context.SearchSimilarJobs.FirstOrDefaultAsync(m => m.Position == id);
            AddedOneHundredPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(JobPosition.HundredPercent);
            foreach (var added in JobPosition.HundredPercent.Split("&PositionId="))
            {
                if (!string.IsNullOrEmpty(added))
                {
                    int number;
                    bool success = int.TryParse(added, out number);
                    if (success)
                    {
                        AddedOneHundredPercentIds += number.ToString() + '-';
                    }
                }
            }
            foreach (var added in JobPosition.NinetyPercent.Split("&PositionId="))
            {
                if (!string.IsNullOrEmpty(added))
                {
                    int number;
                    bool success = int.TryParse(added, out number);
                    if (success)
                    {
                        AddedNinetyPercentIds += number.ToString() + '-';
                    }
                }
            }
            foreach (var added in JobPosition.EightyPercent.Split("&PositionId="))
            {
                if (!string.IsNullOrEmpty(added))
                {
                    int number;
                    bool success = int.TryParse(added, out number);
                    if (success)
                    {
                        AddedEightyPercentIds += number.ToString() + '-';
                    }
                }
            }
            foreach (var added in JobPosition.SeventyPercent.Split("&PositionId="))
            {
                if (!string.IsNullOrEmpty(added))
                {
                    int number;
                    bool success = int.TryParse(added, out number);
                    if (success)
                    {
                        AddedSeventyPercentIds += number.ToString() + '-';
                    }
                }
            }
            if (JobPosition == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task OnPostSelectOneHundredPercent()
        {
            PercentSelection = "100";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            var querystring = string.Empty;
            foreach (var id in AddedOneHundredPercentIds.Split('-'))
            {
                if (!string.IsNullOrEmpty(id))
                {
                    int numberid;
                    bool success = int.TryParse(id, out numberid);
                    if (success)
                    {
                        querystring += "&PositionId=" + numberid.ToString();
                    }
                }
            }
            AddedOneHundredPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(querystring);
        }
        public async Task OnPostSelectNinetyPercent()
        {
            PercentSelection = "90";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            var querystring = string.Empty;
            foreach (var id in AddedNinetyPercentIds.Split('-'))
            {
                if (!string.IsNullOrEmpty(id))
                {
                    int numberid;
                    bool success = int.TryParse(id, out numberid);
                    if (success)
                    {
                        querystring += "&PositionId=" + numberid.ToString();
                    }
                }
            }
            AddedNinetyPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(querystring);
        }

        public async Task OnPostSelectEightyPercent()
        {
            PercentSelection = "80";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            var querystring = string.Empty;
            foreach (var id in AddedEightyPercentIds.Split('-'))
            {
                if (!string.IsNullOrEmpty(id))
                {
                    int numberid;
                    bool success = int.TryParse(id, out numberid);
                    if (success)
                    {
                        querystring += "&PositionId=" + numberid.ToString();
                    }
                }
            }
            AddedEightyPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(querystring);
        }
        public async Task OnPostSelectSeventyPercent()
        {
            PercentSelection = "70";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            var querystring = string.Empty;
            foreach (var id in AddedSeventyPercentIds.Split('-'))
            {
                if (!string.IsNullOrEmpty(id))
                {
                    int numberid;
                    bool success = int.TryParse(id, out numberid);
                    if (success)
                    {
                        querystring += "&PositionId=" + numberid.ToString();
                    }
                }
            }
            AddedSeventyPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(querystring);
        }

        private bool JobPositionExists(int id)
        {
            return _context.JobPositions.Any(e => e.Id == id);
        }
    }
}