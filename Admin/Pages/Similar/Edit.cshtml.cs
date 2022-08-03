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
        private readonly JobGroupService _jobGroupService;

        public EditModel(DataModel.CctDbContext context,
            ILogger<EditModel> logger, JobPositionService jobPositionService, JobGroupService jobGroupService)
        {
            _context = context;
            _logger = logger;
            _jobPositionService = jobPositionService;
            _jobGroupService = jobGroupService;
        }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        [BindProperty]
        public SearchSimilarJob JobPosition { get; set; }
        [BindProperty]
        public JobGroupDto[] JobGroups { get; set; }
        public JobGroupDto CurrentSelectedJobGroup { get; set; }
        public JobPositionDto CurrentPosition { get; set; }
        public JobPositionDto CurrentSelectedPosition { get; set; }
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

        private Dictionary<int, bool> _allJobPositionIds = new Dictionary<int, bool>();

        public async Task<List<JobPositionDto>> GetAllActiveJobs()
        {
            var jobs = await _jobPositionService.GetAllJobPositions();
            return jobs.Where(x => x.Active == 1).ToList();
        }

        public async Task<JobGroupPositionDto[]> GetJobGroupPositionLevelsById(int id)
        {
            return await _jobPositionService.GetJobGroupPositionLevelsById(id);
        }

        public async Task<bool> HasSimilarPositionsOnLoadingPage(int posId)
        {
            var activePositionIds = await _context.JobPositions.Where(x => x.Active == 1).Select(x => x.Id).ToListAsync();
            SearchSimilarJob position = await _context.SearchSimilarJobs.Where(x => x.Position == posId).FirstOrDefaultAsync();

            var hundred = await _jobPositionService.GetJobPositionByIdValues(position.HundredPercent);
            var ninety = await _jobPositionService.GetJobPositionByIdValues(position.NinetyPercent);
            var eighty = await _jobPositionService.GetJobPositionByIdValues(position.EightyPercent);
            var seventy = await _jobPositionService.GetJobPositionByIdValues(position.SeventyPercent);

            JobPositionDto[][] positionsArray = { hundred, ninety,
                eighty, seventy };

            foreach (var group in positionsArray)
            {
                foreach (var pos in group)
                {
                    if (activePositionIds.Contains(pos.JobTitleId))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private async Task PrepareAllJobsDictionary()
        {
            var jobs = await _jobPositionService.GetAllJobPositions();

            foreach (var job in jobs)
            {
                _allJobPositionIds.Add(job.JobTitleId, job.Active == 1);
            }
        }

        private string PrepareQueryString(string ids, int deletedposid)
        {
            var separatedIds = ids.Split('-').Distinct().Where(x => !string.IsNullOrEmpty(x)).ToList();
            var result = string.Empty;

            foreach (var id in separatedIds)
            {
                bool success = int.TryParse(id, out int numberid);
                if (success && numberid != deletedposid)
                {
                    if (_allJobPositionIds.TryGetValue(numberid, out bool boolVar))
                    {
                        result += "&PositionId=" + numberid.ToString();
                    }
                }
            }
            return result;
        }

        private async Task PrepareJobGroupPositions(int jobgroupid)
        {
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(jobgroupid);
        }

        private async Task PreparePageModel(int percent, int jobgroupid, string levelvalue, string subgroupcode, int deletedposid = 0)
        {
            int[] acceptedPercents = { 100, 90, 80, 70 };
            if (!acceptedPercents.Contains(percent))
            {
                percent = 100;
            }

            await PrepareAllJobsDictionary();

            PercentSelection = percent.ToString();
            CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            JobGroups = await _jobPositionService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(jobgroupid);
            if (string.IsNullOrWhiteSpace(levelvalue))
            {
                JobGroupLevelPositions = string.IsNullOrEmpty(subgroupcode) ? await _jobPositionService.GetJobGroupPositionsByLevel(jobgroupid, levelvalue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(jobgroupid, subgroupcode, levelvalue);
                LevelCode = JobGroupPositions.FirstOrDefault().LevelCode;
            }
            SubJobGroupId = JobGroupPositions.FirstOrDefault().SubJobGroupId;
            JobGroupLevelId = JobGroupPositions.FirstOrDefault().LevelId;

            if (percent == 100)
            {
                var querystring = PrepareQueryString(AddedOneHundredPercentIds, deletedposid);
                AddedOneHundredPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(querystring);
            }
            else if (percent == 90)
            {
                var querystring = PrepareQueryString(AddedNinetyPercentIds, deletedposid);
                AddedNinetyPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(querystring);
            }
            else if (percent == 80)
            {
                var querystring = PrepareQueryString(AddedEightyPercentIds, deletedposid);
                AddedEightyPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(querystring);
            }
            else if (percent == 70)
            {
                var querystring = PrepareQueryString(AddedSeventyPercentIds, deletedposid);
                AddedSeventyPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(querystring);
            }

            if (deletedposid != 0)
            {
                if (percent == 100)
                {
                    AddedOneHundredPercentIds = string.Empty;
                    foreach (var position in AddedOneHundredPercentJobPositions)
                    {
                        AddedOneHundredPercentIds += position.JobTitleId.ToString() + '-';
                    }
                }
                else if (percent == 90)
                {
                    AddedNinetyPercentIds = string.Empty;
                    foreach (var position in AddedNinetyPercentJobPositions)
                    {
                        AddedNinetyPercentIds += position.JobTitleId.ToString() + '-';
                    }
                }
                else if (percent == 80)
                {
                    AddedEightyPercentIds = string.Empty;
                    foreach (var position in AddedEightyPercentJobPositions)
                    {
                        AddedEightyPercentIds += position.JobTitleId.ToString() + '-';
                    }
                }
                else if (percent == 70)
                {
                    AddedSeventyPercentIds = string.Empty;
                    foreach (var position in AddedSeventyPercentJobPositions)
                    {
                        AddedSeventyPercentIds += position.JobTitleId.ToString() + '-';
                    }
                }
            }

        }

        public async Task<IActionResult> OnGetAsync(int? id, int? percent, int? groupId, string? level)
        {
            if (id == null)
            {
                return NotFound();
            }

            try
            {
                CurrentPosition = await _jobPositionService.GetJobPositionById(Id);
            }
            catch
            {
                return NotFound();
            }

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
                if (percent == 90)
                {
                    PercentSelection = "90";
                }
                else if (percent == 80)
                {
                    PercentSelection = "80";
                }
                else if (percent == 70)
                {
                    PercentSelection = "70";
                }
            }

            JobGroups = await _jobPositionService.GetJobGroups();
            JobGroupPositions = await _jobPositionService.GetJobGroupPositionLevelsById(JobGroups[0].Id);
            CurrentSelectedJobGroup = await _jobPositionService.GetJobGroupById(CurrentPosition.JobGroupId);
            JobGroupLevelPositions = string.IsNullOrEmpty(JobGroupPositions.FirstOrDefault().SubGroupCode) ? await _jobPositionService.GetJobGroupPositionsByLevel(JobGroupPositions.FirstOrDefault().JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(JobGroupPositions.FirstOrDefault().JobGroupId, JobGroupPositions.FirstOrDefault().SubGroupCode, JobGroupPositions.FirstOrDefault().LevelValue);
            SubJobGroupId = JobGroupPositions.FirstOrDefault().SubJobGroupId;
            JobGroupLevelId = JobGroupPositions.FirstOrDefault().LevelId;
            LevelCode = CurrentPosition.LevelCode;
            SubGroupCode = JobGroupPositions.FirstOrDefault().SubGroupCode;
            LevelValue = JobGroupPositions.FirstOrDefault().LevelValue;

            if (groupId != null)
            {
                JobGroupDto group = null;
                try
                {
                    group = await _jobPositionService.GetJobGroupById(groupId.Value);
                }
                catch { }

                if (group != null)
                {
                    CurrentSelectedJobGroup = group;
                }
            }

            if (level != null)
            {
                var levels = (await _jobGroupService.GetJobGroupPositionsById(CurrentSelectedJobGroup.Id)).ToList().Select(e => e.LevelCode.ToUpper());

                if (levels.Contains(level.ToUpper()))
                {
                    LevelCode = level.ToUpper();
                }
            }

            AddedOneHundredPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(JobPosition.HundredPercent);
            AddedNinetyPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(JobPosition.NinetyPercent);
            AddedEightyPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(JobPosition.EightyPercent);
            AddedSeventyPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(JobPosition.SeventyPercent);

            await PrepareAllJobsDictionary();

            string[] addedPositionIds = { JobPosition.HundredPercent, JobPosition.NinetyPercent,
                    JobPosition.EightyPercent, JobPosition.SeventyPercent };
            string[] addedIdsToCopy = new string[4];

            for (int i = 0; i < addedPositionIds.Length; i++)
            {
                var ids = addedPositionIds[i].Split("&PositionId=").Distinct().Where(x => !string.IsNullOrEmpty(x)).ToList();

                addedIdsToCopy[i] = string.Empty;

                foreach (var added in ids)
                {
                    bool success = int.TryParse(added, out int number);
                    if (success)
                    {
                        if (_allJobPositionIds.TryGetValue(number, out bool boolVar))
                        {
                            addedIdsToCopy[i] += number.ToString() + '-';
                        }
                    }
                }
            }

            AddedOneHundredPercentIds = addedIdsToCopy[0];
            AddedNinetyPercentIds = addedIdsToCopy[1];
            AddedEightyPercentIds = addedIdsToCopy[2];
            AddedSeventyPercentIds = addedIdsToCopy[3];

            return Page();
        }

        public async Task<IActionResult> OnPostEdit()
        {
            await PrepareJobGroupPositions(JobGroupId);
            await PreparePageModel(int.Parse(PercentSelection), JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue, JobGroupPositions.FirstOrDefault().SubGroupCode);

            bool onePositionAdded = ((!string.IsNullOrWhiteSpace(AddedOneHundredPercentIds)) ||
                (!string.IsNullOrWhiteSpace(AddedNinetyPercentIds)) ||
                (!string.IsNullOrWhiteSpace(AddedEightyPercentIds)) ||
                (!string.IsNullOrWhiteSpace(AddedSeventyPercentIds)));

            if (!onePositionAdded)
            {
                ModelState.AddModelError("PercentSelection", "Make sure that at least one similar position has been added");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            string[] addedPositionIds = { AddedOneHundredPercentIds, AddedNinetyPercentIds, AddedEightyPercentIds, AddedSeventyPercentIds };
            string[] queryStrings = new string[4];

            for (int i = 0; i < addedPositionIds.Length; i++)
            {
                var ids = addedPositionIds[i].Split('-').Distinct().Where(x => !string.IsNullOrEmpty(x)).ToList();

                queryStrings[i] = string.Empty;

                foreach (var id in ids)
                {
                    bool success = int.TryParse(id, out int numberid);
                    if (success)
                    {
                        if (_allJobPositionIds.TryGetValue(numberid, out bool boolVar))
                        {
                            queryStrings[i] += "&PositionId=" + numberid.ToString();
                        }
                    }
                }
            }

            JobPosition.HundredPercent = queryStrings[0];
            JobPosition.NinetyPercent = queryStrings[1];
            JobPosition.EightyPercent = queryStrings[2];
            JobPosition.SeventyPercent = queryStrings[3];

            await _jobPositionService.UpdateSimilarPositions(JobPosition);

            return RedirectToPage("Details", new { Id });
        }

        public async Task OnPostGroupOneHundredPercent()
        {
            await PrepareJobGroupPositions(JobGroupId);
            await PreparePageModel(100, JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue, JobGroupPositions.FirstOrDefault().SubGroupCode);
        }

        public async Task OnPostLevelOneHundredPercent(int jobgroupid, string levelvalue, string subgroupcode)
        {
            JobGroupLevelPositions = string.IsNullOrEmpty(subgroupcode) ? await _jobPositionService.GetJobGroupPositionsByLevel(jobgroupid, levelvalue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(jobgroupid, subgroupcode, levelvalue);
            await PrepareJobGroupPositions(jobgroupid);
            await PreparePageModel(100, jobgroupid, levelvalue, subgroupcode);
        }

        public async Task OnPostGroupNinetyPercent()
        {
            await PrepareJobGroupPositions(JobGroupId);
            await PreparePageModel(90, JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue, JobGroupPositions.FirstOrDefault().SubGroupCode);
        }

        public async Task OnPostLevelNinetyPercent(int jobgroupid, string levelvalue, string subgroupcode)
        {
            JobGroupLevelPositions = string.IsNullOrEmpty(subgroupcode) ? await _jobPositionService.GetJobGroupPositionsByLevel(jobgroupid, levelvalue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(jobgroupid, subgroupcode, levelvalue);
            await PrepareJobGroupPositions(jobgroupid);
            await PreparePageModel(90, jobgroupid, levelvalue, subgroupcode);
        }

        public async Task OnPostGroupEightyPercent()
        {
            await PrepareJobGroupPositions(JobGroupId);
            await PreparePageModel(80, JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue, JobGroupPositions.FirstOrDefault().SubGroupCode);
        }

        public async Task OnPostLevelEightyPercent(int jobgroupid, string levelvalue, string subgroupcode)
        {
            JobGroupLevelPositions = string.IsNullOrEmpty(subgroupcode) ? await _jobPositionService.GetJobGroupPositionsByLevel(jobgroupid, levelvalue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(jobgroupid, subgroupcode, levelvalue);
            await PrepareJobGroupPositions(jobgroupid);
            await PreparePageModel(80, jobgroupid, levelvalue, subgroupcode);
        }

        public async Task OnPostGroupSeventyPercent()
        {
            await PrepareJobGroupPositions(JobGroupId);
            await PreparePageModel(70, JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue, JobGroupPositions.FirstOrDefault().SubGroupCode);
        }

        public async Task OnPostLevelSeventyPercent(int jobgroupid, string levelvalue, string subgroupcode)
        {
            JobGroupLevelPositions = string.IsNullOrEmpty(subgroupcode) ? await _jobPositionService.GetJobGroupPositionsByLevel(jobgroupid, levelvalue) : await _jobPositionService.GetJobGroupPositionsBySubGroupLevel(jobgroupid, subgroupcode, levelvalue);
            await PrepareJobGroupPositions(jobgroupid);
            await PreparePageModel(70, jobgroupid, levelvalue, subgroupcode);
        }

        public async Task OnPostSelectOneHundredPercent()
        {
            await PrepareJobGroupPositions(JobGroupId);
            await PreparePageModel(100, JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue, JobGroupPositions.FirstOrDefault().SubGroupCode);
        }

        public async Task OnPostSelectNinetyPercent()
        {
            await PrepareJobGroupPositions(JobGroupId);
            await PreparePageModel(90, JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue, JobGroupPositions.FirstOrDefault().SubGroupCode);
        }

        public async Task OnPostSelectEightyPercent()
        {
            await PrepareJobGroupPositions(JobGroupId);
            await PreparePageModel(80, JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue, JobGroupPositions.FirstOrDefault().SubGroupCode);
        }

        public async Task OnPostSelectSeventyPercent()
        {
            await PrepareJobGroupPositions(JobGroupId);
            await PreparePageModel(70, JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue, JobGroupPositions.FirstOrDefault().SubGroupCode);
        }

        public async Task OnPostAddOneHundredPercentSimilarPosition()
        {
            await PrepareJobGroupPositions(JobGroupId);
            AddedOneHundredPercentIds += SelectedJobPositionId.ToString() + '-';
            await PreparePageModel(100, JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue, JobGroupPositions.FirstOrDefault().SubGroupCode);
        }

        public async Task OnPostDeleteOneHundredPercentSimilarPosition(int deletepositionid)
        {
            await PrepareJobGroupPositions(JobGroupId);
            await PreparePageModel(100, JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue, JobGroupPositions.FirstOrDefault().SubGroupCode, deletepositionid);
        }

        public async Task OnPostAddNinetyPercentSimilarPosition()
        {
            await PrepareJobGroupPositions(JobGroupId);
            AddedNinetyPercentIds += SelectedJobPositionId.ToString() + '-';
            await PreparePageModel(90, JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue, JobGroupPositions.FirstOrDefault().SubGroupCode);
        }

        public async Task OnPostDeleteNinetyPercentSimilarPosition(int deletepositionid)
        {
            await PrepareJobGroupPositions(JobGroupId);
            await PreparePageModel(90, JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue, JobGroupPositions.FirstOrDefault().SubGroupCode, deletepositionid);
        }

        public async Task OnPostAddEightyPercentSimilarPosition()
        {
            await PrepareJobGroupPositions(JobGroupId);
            AddedEightyPercentIds += SelectedJobPositionId.ToString() + '-';
            await PreparePageModel(80, JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue, JobGroupPositions.FirstOrDefault().SubGroupCode);
        }

        public async Task OnPostDeleteEightyPercentSimilarPosition(int deletepositionid)
        {
            await PrepareJobGroupPositions(JobGroupId);
            await PreparePageModel(80, JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue, JobGroupPositions.FirstOrDefault().SubGroupCode, deletepositionid);
        }

        public async Task OnPostAddSeventyPercentSimilarPosition()
        {
            await PrepareJobGroupPositions(JobGroupId);
            AddedSeventyPercentIds += SelectedJobPositionId.ToString() + '-';
            await PreparePageModel(70, JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue, JobGroupPositions.FirstOrDefault().SubGroupCode);
        }

        public async Task OnPostDeleteSeventyPercentSimilarPosition(int deletepositionid)
        {
            await PrepareJobGroupPositions(JobGroupId);
            await PreparePageModel(70, JobGroupId, JobGroupPositions.FirstOrDefault().LevelValue, JobGroupPositions.FirstOrDefault().SubGroupCode, deletepositionid);
        }

    }
}