using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Admin.Data;
using Microsoft.Extensions.Logging;
using Business.Dtos.JobGroups;
using Business.Dtos.JobPositions;
using System.Threading;

namespace Admin.Pages.Similar
{
    public class EditModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly ILogger<EditModel> _logger;
        private readonly JobPositionService _jobPositionService;

        public EditModel(DataModel.CctDbContext context,
            ILogger<EditModel> logger, JobPositionService jobPositionService)
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

        public async Task<List<JobPositionDto>> GetAllActiveJobs()
        {
            var jobs = await _jobPositionService.GetAllJobPositions();
            return jobs.Where(x => x.Active == 1).ToList();
        }

        public async Task<JobGroupPositionDto[]> GetJobGroupPositionLevelsById(int id)
        {
            return await _jobPositionService.GetJobGroupPositionLevelsById(id);
        }

        public async Task<IActionResult> OnGetAsync(int? id)
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

            JobPosition = await _context.SearchSimilarJobs.FirstOrDefaultAsync(m => m.Position == id);

            if (JobPosition == null)
            {
                return Redirect("/Similar/Create?id=" + CurrentPosition.JobTitleId);
            }

            PercentSelection = "100";
            JobGroups = await _jobPositionService.GetJobGroups();
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroups[0].Id);
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(CurrentPosition.JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(JobGroupPositions.FirstOrDefault().SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupPositions.FirstOrDefault().JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupPositions.FirstOrDefault().JobGroupId, JobGroupPositions.FirstOrDefault().SubGroupCode, JobGroupPositions.FirstOrDefault().LevelValue);
            SubJobGroupId = JobGroupPositions.FirstOrDefault().SubJobGroupId;
            JobGroupLevelId = JobGroupPositions.FirstOrDefault().LevelId;
            LevelCode = CurrentPosition.LevelCode;
            SubGroupCode = JobGroupPositions.FirstOrDefault().SubGroupCode;
            LevelValue = JobGroupPositions.FirstOrDefault().LevelValue;
            CurrentSelectedPosition = JobGroupLevelPositions.Where(e => e.Active != 0).FirstOrDefault();
            if (CurrentSelectedPosition != null)
            {
                CurrentSelectedJobTitleEng = CurrentSelectedPosition?.JobTitleEng;
                CurrentSelectedJobTitleFre = CurrentSelectedPosition?.JobTitleFre;
                SelectedJobPositionId = CurrentSelectedPosition.JobTitleId;
            }

            AddedOneHundredPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(JobPosition.HundredPercent);
            foreach (var added in JobPosition.HundredPercent.Split("&PositionId=").Distinct())
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
            foreach (var added in JobPosition.NinetyPercent.Split("&PositionId=").Distinct())
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
            foreach (var added in JobPosition.EightyPercent.Split("&PositionId=").Distinct())
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
            foreach (var added in JobPosition.SeventyPercent.Split("&PositionId=").Distinct())
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
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostEdit()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var querystring100 = string.Empty;
            foreach (var id in AddedOneHundredPercentIds.Split('-').Distinct())
            {
                if (!string.IsNullOrEmpty(id))
                {
                    int numberid;
                    bool success = int.TryParse(id, out numberid);
                    if (success)
                    {
                        querystring100 += "&PositionId=" + numberid.ToString();
                    }
                }
            }
            var querystring90 = string.Empty;
            foreach (var id in AddedNinetyPercentIds.Split('-').Distinct())
            {
                if (!string.IsNullOrEmpty(id))
                {
                    int numberid;
                    bool success = int.TryParse(id, out numberid);
                    if (success)
                    {
                        querystring90 += "&PositionId=" + numberid.ToString();
                    }
                }
            }
            var querystring80 = string.Empty;
            foreach (var id in AddedEightyPercentIds.Split('-').Distinct())
            {
                if (!string.IsNullOrEmpty(id))
                {
                    int numberid;
                    bool success = int.TryParse(id, out numberid);
                    if (success)
                    {
                        querystring80 += "&PositionId=" + numberid.ToString();
                    }
                }
            }
            var querystring70 = string.Empty;
            foreach (var id in AddedSeventyPercentIds.Split('-').Distinct())
            {
                if (!string.IsNullOrEmpty(id))
                {
                    int numberid;
                    bool success = int.TryParse(id, out numberid);
                    if (success)
                    {
                        querystring70 += "&PositionId=" + numberid.ToString();
                    }
                }
            }
            JobPosition.HundredPercent = querystring100;
            JobPosition.NinetyPercent = querystring90;
            JobPosition.EightyPercent = querystring80;
            JobPosition.SeventyPercent = querystring70;
            _jobPositionService.UpdateSimilarPositions(JobPosition);
            Thread.Sleep(5000);
            return RedirectToPage("Details", new { Id });
        }
        public async Task OnPostGroupOneHundredPercent()
        {
            PercentSelection = "100";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobPositionService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(JobGroupPositions.FirstOrDefault().SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupPositions.FirstOrDefault().JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupPositions.FirstOrDefault().JobGroupId, JobGroupPositions.FirstOrDefault().SubGroupCode, JobGroupPositions.FirstOrDefault().LevelValue);
            SubJobGroupId = JobGroupPositions.FirstOrDefault().SubJobGroupId;
            JobGroupLevelId = JobGroupPositions.FirstOrDefault().LevelId;
            LevelCode = JobGroupPositions.FirstOrDefault().LevelCode;
            CurrentSelectedPosition = JobGroupLevelPositions.Where(e => e.Active != 0).FirstOrDefault();
            if (CurrentSelectedPosition != null)
            {
                CurrentSelectedJobTitleEng = CurrentSelectedPosition?.JobTitleEng;
                CurrentSelectedJobTitleFre = CurrentSelectedPosition?.JobTitleFre;
                SelectedJobPositionId = CurrentSelectedPosition.JobTitleId;
            }
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

        public async Task OnPostLevelOneHundredPercent(int jobgroupid, string levelvalue, string subgroupcode)
        {
            PercentSelection = "100";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(jobgroupid);
            JobGroupLevelPositions = string.IsNullOrEmpty(subgroupcode) ? await _jobPositionService.GetJobGroupPositionsByLevel(jobgroupid, levelvalue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(jobgroupid, subgroupcode, levelvalue);
            JobGroups = await _jobPositionService.GetJobGroups();
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(jobgroupid);
            CurrentSelectedPosition = JobGroupLevelPositions.Where(e => e.Active != 0).FirstOrDefault();
            if (CurrentSelectedPosition != null)
            {
                CurrentSelectedJobTitleEng = CurrentSelectedPosition?.JobTitleEng;
                CurrentSelectedJobTitleFre = CurrentSelectedPosition?.JobTitleFre;
                SelectedJobPositionId = CurrentSelectedPosition.JobTitleId;
            }
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
        public async Task OnPostGroupNinetyPercent()
        {
            PercentSelection = "90";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobPositionService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(JobGroupPositions.FirstOrDefault().SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupPositions.FirstOrDefault().JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupPositions.FirstOrDefault().JobGroupId, JobGroupPositions.FirstOrDefault().SubGroupCode, JobGroupPositions.FirstOrDefault().LevelValue);
            SubJobGroupId = JobGroupPositions.FirstOrDefault().SubJobGroupId;
            JobGroupLevelId = JobGroupPositions.FirstOrDefault().LevelId;
            LevelCode = JobGroupPositions.FirstOrDefault().LevelCode;
            CurrentSelectedPosition = JobGroupLevelPositions.Where(e => e.Active != 0).FirstOrDefault();
            if (CurrentSelectedPosition != null)
            {
                CurrentSelectedJobTitleEng = CurrentSelectedPosition?.JobTitleEng;
                CurrentSelectedJobTitleFre = CurrentSelectedPosition?.JobTitleFre;
                SelectedJobPositionId = CurrentSelectedPosition.JobTitleId;
            }
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

        public async Task OnPostLevelNinetyPercent(int jobgroupid, string levelvalue, string subgroupcode)
        {
            PercentSelection = "90";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(jobgroupid);
            JobGroupLevelPositions = string.IsNullOrEmpty(subgroupcode) ? await _jobPositionService.GetJobGroupPositionsByLevel(jobgroupid, levelvalue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(jobgroupid, subgroupcode, levelvalue);
            JobGroups = await _jobPositionService.GetJobGroups();
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(jobgroupid);
            CurrentSelectedPosition = JobGroupLevelPositions.Where(e => e.Active != 0).FirstOrDefault();
            if (CurrentSelectedPosition != null)
            {
                CurrentSelectedJobTitleEng = CurrentSelectedPosition?.JobTitleEng;
                CurrentSelectedJobTitleFre = CurrentSelectedPosition?.JobTitleFre;
                SelectedJobPositionId = CurrentSelectedPosition.JobTitleId;
            }
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
        public async Task OnPostGroupEightyPercent()
        {
            PercentSelection = "80";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobPositionService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(JobGroupPositions.FirstOrDefault().SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupPositions.FirstOrDefault().JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupPositions.FirstOrDefault().JobGroupId, JobGroupPositions.FirstOrDefault().SubGroupCode, JobGroupPositions.FirstOrDefault().LevelValue);
            SubJobGroupId = JobGroupPositions.FirstOrDefault().SubJobGroupId;
            JobGroupLevelId = JobGroupPositions.FirstOrDefault().LevelId;
            LevelCode = JobGroupPositions.FirstOrDefault().LevelCode;
            CurrentSelectedPosition = JobGroupLevelPositions.Where(e => e.Active != 0).FirstOrDefault();
            if (CurrentSelectedPosition != null)
            {
                CurrentSelectedJobTitleEng = CurrentSelectedPosition?.JobTitleEng;
                CurrentSelectedJobTitleFre = CurrentSelectedPosition?.JobTitleFre;
                SelectedJobPositionId = CurrentSelectedPosition.JobTitleId;
            }
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

        public async Task OnPostLevelEightyPercent(int jobgroupid, string levelvalue, string subgroupcode)
        {
            PercentSelection = "80";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(jobgroupid);
            JobGroupLevelPositions = string.IsNullOrEmpty(subgroupcode) ? await _jobPositionService.GetJobGroupPositionsByLevel(jobgroupid, levelvalue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(jobgroupid, subgroupcode, levelvalue);
            JobGroups = await _jobPositionService.GetJobGroups();
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(jobgroupid);
            CurrentSelectedPosition = JobGroupLevelPositions.Where(e => e.Active != 0).FirstOrDefault();
            if (CurrentSelectedPosition != null)
            {
                CurrentSelectedJobTitleEng = CurrentSelectedPosition?.JobTitleEng;
                CurrentSelectedJobTitleFre = CurrentSelectedPosition?.JobTitleFre;
                SelectedJobPositionId = CurrentSelectedPosition.JobTitleId;
            }
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
        public async Task OnPostGroupSeventyPercent()
        {
            PercentSelection = "70";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobPositionService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(JobGroupPositions.FirstOrDefault().SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupPositions.FirstOrDefault().JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupPositions.FirstOrDefault().JobGroupId, JobGroupPositions.FirstOrDefault().SubGroupCode, JobGroupPositions.FirstOrDefault().LevelValue);
            SubJobGroupId = JobGroupPositions.FirstOrDefault().SubJobGroupId;
            JobGroupLevelId = JobGroupPositions.FirstOrDefault().LevelId;
            LevelCode = JobGroupPositions.FirstOrDefault().LevelCode;
            CurrentSelectedPosition = JobGroupLevelPositions.Where(e => e.Active != 0).FirstOrDefault();
            if (CurrentSelectedPosition != null)
            {
                CurrentSelectedJobTitleEng = CurrentSelectedPosition?.JobTitleEng;
                CurrentSelectedJobTitleFre = CurrentSelectedPosition?.JobTitleFre;
                SelectedJobPositionId = CurrentSelectedPosition.JobTitleId;
            }
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

        public async Task OnPostLevelSeventyPercent(int jobgroupid, string levelvalue, string subgroupcode)
        {
            PercentSelection = "70";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(jobgroupid);
            JobGroupLevelPositions = string.IsNullOrEmpty(subgroupcode) ? await _jobPositionService.GetJobGroupPositionsByLevel(jobgroupid, levelvalue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(jobgroupid, subgroupcode, levelvalue);
            JobGroups = await _jobPositionService.GetJobGroups();
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(jobgroupid);
            CurrentSelectedPosition = JobGroupLevelPositions.Where(e => e.Active != 0).FirstOrDefault();
            if (CurrentSelectedPosition != null)
            {
                CurrentSelectedJobTitleEng = CurrentSelectedPosition?.JobTitleEng;
                CurrentSelectedJobTitleFre = CurrentSelectedPosition?.JobTitleFre;
                SelectedJobPositionId = CurrentSelectedPosition.JobTitleId;
            }
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
        public async Task OnPostSelectOneHundredPercent()
        {
            PercentSelection = "100";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            if (SelectedJobPositionId != 0)
            {
                var positiondto = await _jobPositionService.GetJobPositionById(SelectedJobPositionId);
                CurrentSelectedJobTitleEng = positiondto.JobTitleEng;
                CurrentSelectedJobTitleFre = positiondto.JobTitleFre;
                SelectedJobPositionId = positiondto.JobTitleId;
            }
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobPositionService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupId, LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupId, SubGroupCode, LevelValue);
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
            if (SelectedJobPositionId != 0)
            {
                var positiondto = await _jobPositionService.GetJobPositionById(SelectedJobPositionId);
                CurrentSelectedJobTitleEng = positiondto.JobTitleEng;
                CurrentSelectedJobTitleFre = positiondto.JobTitleFre;
                SelectedJobPositionId = positiondto.JobTitleId;
            }
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobPositionService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupId, LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupId, SubGroupCode, LevelValue);
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
            if (SelectedJobPositionId != 0)
            {
                var positiondto = await _jobPositionService.GetJobPositionById(SelectedJobPositionId);
                CurrentSelectedJobTitleEng = positiondto.JobTitleEng;
                CurrentSelectedJobTitleFre = positiondto.JobTitleFre;
                SelectedJobPositionId = positiondto.JobTitleId;
            }
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobPositionService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupId, LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupId, SubGroupCode, LevelValue);
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
            if (SelectedJobPositionId != 0)
            {
                var positiondto = await _jobPositionService.GetJobPositionById(SelectedJobPositionId);
                CurrentSelectedJobTitleEng = positiondto.JobTitleEng;
                CurrentSelectedJobTitleFre = positiondto.JobTitleFre;
                SelectedJobPositionId = positiondto.JobTitleId;
            }
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobPositionService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupId, LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupId, SubGroupCode, LevelValue);
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

        public async Task OnPostAddOneHundredPercentSimilarPosition()
        {
            PercentSelection = "100";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            if (SelectedJobPositionId != 0)
            {
                var positiondto = await _jobPositionService.GetJobPositionById(SelectedJobPositionId);
                CurrentSelectedJobTitleEng = positiondto.JobTitleEng;
                CurrentSelectedJobTitleFre = positiondto.JobTitleFre;
                SelectedJobPositionId = positiondto.JobTitleId;
            }
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobPositionService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupId, LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupId, SubGroupCode, LevelValue);
            AddedOneHundredPercentIds += SelectedJobPositionId.ToString() + '-';
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
        public async Task OnPostDeleteOneHundredPercentSimilarPosition(int deletepositionid)
        {
            PercentSelection = "100";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            if (SelectedJobPositionId != 0)
            {
                var positiondto = await _jobPositionService.GetJobPositionById(SelectedJobPositionId);
                CurrentSelectedJobTitleEng = positiondto.JobTitleEng;
                CurrentSelectedJobTitleFre = positiondto.JobTitleFre;
                SelectedJobPositionId = positiondto.JobTitleId;
            }
            var querystring = string.Empty;
            foreach (var id in AddedOneHundredPercentIds.Split('-'))
            {
                if (!string.IsNullOrEmpty(id))
                {
                    int numberid;
                    bool success = int.TryParse(id, out numberid);
                    if (success && numberid != deletepositionid)
                    {
                        querystring += "&PositionId=" + numberid.ToString();
                    }
                }
            }
            AddedOneHundredPercentIds = string.Empty;
            AddedOneHundredPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(querystring);
            foreach (var position in AddedOneHundredPercentJobPositions)
            {
                AddedOneHundredPercentIds += position.JobTitleId.ToString() + '-';
            }
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobPositionService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupId, LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupId, SubGroupCode, LevelValue);
        }
        public async Task OnPostAddNinetyPercentSimilarPosition()
        {
            PercentSelection = "90";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            if (SelectedJobPositionId != 0)
            {
                var positiondto = await _jobPositionService.GetJobPositionById(SelectedJobPositionId);
                CurrentSelectedJobTitleEng = positiondto.JobTitleEng;
                CurrentSelectedJobTitleFre = positiondto.JobTitleFre;
                SelectedJobPositionId = positiondto.JobTitleId;
            }
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobPositionService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(CurrentPosition.JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupId, LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupId, SubGroupCode, LevelValue);
            AddedNinetyPercentIds += SelectedJobPositionId.ToString() + '-';
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
        public async Task OnPostDeleteNinetyPercentSimilarPosition(int deletepositionid)
        {
            PercentSelection = "90";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            if (SelectedJobPositionId != 0)
            {
                var positiondto = await _jobPositionService.GetJobPositionById(SelectedJobPositionId);
                CurrentSelectedJobTitleEng = positiondto.JobTitleEng;
                CurrentSelectedJobTitleFre = positiondto.JobTitleFre;
                SelectedJobPositionId = positiondto.JobTitleId;
            }
            var querystring = string.Empty;
            foreach (var id in AddedNinetyPercentIds.Split('-'))
            {
                if (!string.IsNullOrEmpty(id))
                {
                    int numberid;
                    bool success = int.TryParse(id, out numberid);
                    if (success && numberid != deletepositionid)
                    {
                        querystring += "&PositionId=" + numberid.ToString();
                    }
                }
            }
            AddedNinetyPercentIds = string.Empty;
            AddedNinetyPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(querystring);
            foreach (var position in AddedNinetyPercentJobPositions)
            {
                AddedNinetyPercentIds += position.JobTitleId.ToString() + '-';
            }
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobPositionService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupId, LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupId, SubGroupCode, LevelValue);
        }
        public async Task OnPostAddEightyPercentSimilarPosition()
        {
            PercentSelection = "80";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            if (SelectedJobPositionId != 0)
            {
                var positiondto = await _jobPositionService.GetJobPositionById(SelectedJobPositionId);
                CurrentSelectedJobTitleEng = positiondto.JobTitleEng;
                CurrentSelectedJobTitleFre = positiondto.JobTitleFre;
                SelectedJobPositionId = positiondto.JobTitleId;
            }
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobPositionService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupId, LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupId, SubGroupCode, LevelValue);
            AddedEightyPercentIds += SelectedJobPositionId.ToString() + '-';
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
        public async Task OnPostDeleteEightyPercentSimilarPosition(int deletepositionid)
        {
            PercentSelection = "80";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            if (SelectedJobPositionId != 0)
            {
                var positiondto = await _jobPositionService.GetJobPositionById(SelectedJobPositionId);
                CurrentSelectedJobTitleEng = positiondto.JobTitleEng;
                CurrentSelectedJobTitleFre = positiondto.JobTitleFre;
                SelectedJobPositionId = positiondto.JobTitleId;
            }
            var querystring = string.Empty;
            foreach (var id in AddedEightyPercentIds.Split('-'))
            {
                if (!string.IsNullOrEmpty(id))
                {
                    int numberid;
                    bool success = int.TryParse(id, out numberid);
                    if (success && numberid != deletepositionid)
                    {
                        querystring += "&PositionId=" + numberid.ToString();
                    }
                }
            }
            AddedEightyPercentIds = string.Empty;
            AddedEightyPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(querystring);
            foreach (var position in AddedEightyPercentJobPositions)
            {
                AddedEightyPercentIds += position.JobTitleId.ToString() + '-';
            }
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobPositionService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupId, LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupId, SubGroupCode, LevelValue);
        }
        public async Task OnPostAddSeventyPercentSimilarPosition()
        {
            PercentSelection = "70";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            if (SelectedJobPositionId != 0)
            {
                var positiondto = await _jobPositionService.GetJobPositionById(SelectedJobPositionId);
                CurrentSelectedJobTitleEng = positiondto.JobTitleEng;
                CurrentSelectedJobTitleFre = positiondto.JobTitleFre;
                SelectedJobPositionId = positiondto.JobTitleId;
            }
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobPositionService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupId, LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupId, SubGroupCode, LevelValue);
            AddedSeventyPercentIds += SelectedJobPositionId.ToString() + '-';
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
        public async Task OnPostDeleteSeventyPercentSimilarPosition(int deletepositionid)
        {
            PercentSelection = "70";
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            if (SelectedJobPositionId != 0)
            {
                var positiondto = await _jobPositionService.GetJobPositionById(SelectedJobPositionId);
                CurrentSelectedJobTitleEng = positiondto.JobTitleEng;
                CurrentSelectedJobTitleFre = positiondto.JobTitleFre;
                SelectedJobPositionId = positiondto.JobTitleId;
            }
            var querystring = string.Empty;
            foreach (var id in AddedSeventyPercentIds.Split('-'))
            {
                if (!string.IsNullOrEmpty(id))
                {
                    int numberid;
                    bool success = int.TryParse(id, out numberid);
                    if (success && numberid != deletepositionid)
                    {
                        querystring += "&PositionId=" + numberid.ToString();
                    }
                }
            }
            AddedSeventyPercentIds = string.Empty;
            AddedSeventyPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(querystring);
            foreach (var position in AddedSeventyPercentJobPositions)
            {
                AddedSeventyPercentIds += position.JobTitleId.ToString() + '-';
            }
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobPositionService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupId, LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupId, SubGroupCode, LevelValue);
        }
        private bool JobPositionExists(int id)
        {
            return _context.JobPositions.Any(e => e.Id == id);
        }
    }
}