using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataModel;
using Admin.Data;
using Microsoft.Extensions.Logging;
using Business.Dtos.JobGroups;
using Business.Dtos.JobPositions;
using System.Threading;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Admin.Pages.Similar
{
    public class CreateModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly ILogger<CreateModel> _logger;
        private readonly JobPositionService _jobPositionService;

        public CreateModel(DataModel.CctDbContext context,
            ILogger<CreateModel> logger, JobPositionService jobPositionService)
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
        public JobPositionDto CurrentPosition { get; set; }
        [BindProperty(SupportsGet = true)]
        public int SelectedJobPositionId { get; set; }
        public JobGroupPositionDto[] JobGroupPositions { get; set; }
        [BindProperty(SupportsGet = true)]
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

        [BindProperty(SupportsGet = true)]
        public bool CopyingAPosition { get; set; } = false;

        public JobPositionDto PositionBeingCopied { get; set; }

        private Dictionary<int, bool> _allJobPositionIds = new Dictionary<int, bool>();

        public async Task<List<JobPositionDto>> GetAllActiveJobs()
        {
            var jobs = await _jobPositionService.GetAllJobPositions();
            return jobs.Where(x => x.Active == 1).ToList();
        }

        private async Task PrepareAllJobsDictionary()
        {
            var jobs = await _jobPositionService.GetAllJobPositions();

            foreach (var job in jobs)
            {
                _allJobPositionIds.Add(job.JobTitleId, job.Active == 1);
            }
        }

        public async Task<JobGroupPositionDto[]> GetJobGroupPositionLevelsById(int id)
        {
            return await _jobPositionService.GetJobGroupPositionLevelsById(id);
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

        public async Task<IActionResult> OnGetAsync(int? id, int? copyid)
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

            var copiedPositionSimilar = new SearchSimilarJob();
            if (copyid != null)
            {
                try
                {
                    PositionBeingCopied = await _jobPositionService.GetJobPositionById(copyid.Value);
                }
                catch
                {
                    return NotFound();
                }

                if (PositionBeingCopied == null)
                {
                    return NotFound();
                }
                if (PositionBeingCopied.Active != 1)
                {
                    return NotFound();
                }

                copiedPositionSimilar = await _context.SearchSimilarJobs.FirstOrDefaultAsync(m => m.Position == copyid.Value);

                if (copiedPositionSimilar == null)
                {
                    return NotFound();
                }

                CopyingAPosition = true;
            }

            if (!CopyingAPosition)
            {
                JobPosition = await _context.SearchSimilarJobs.FirstOrDefaultAsync(m => m.Position == id);

                if (JobPosition != null) // if the position already has some similar jobs, users should see the edit page
                {
                    return Redirect("/Similar/Edit?id=" + CurrentPosition.JobTitleId);
                }
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

            if (CopyingAPosition)
            {
                await PrepareAllJobsDictionary();
                AddedOneHundredPercentJobPositions = await _jobPositionService.GetJobPositionByIdValues(copiedPositionSimilar.HundredPercent);

                string[] addedPositionIds = { copiedPositionSimilar.HundredPercent, copiedPositionSimilar.NinetyPercent,
                    copiedPositionSimilar.EightyPercent, copiedPositionSimilar.SeventyPercent };
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
            }

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

            var querystring100 = queryStrings[0];
            var querystring90 = queryStrings[1];
            var querystring80 = queryStrings[2];
            var querystring70 = queryStrings[3];

            bool creatingSimilarPositions = true;

            if (CopyingAPosition)
            {
                if (_context.SearchSimilarJobs.Where(x => x.Position == Id).Any())
                {
                    creatingSimilarPositions = false;
                }
            }

            if (creatingSimilarPositions)
            {
                await _jobPositionService.PostSimilarPositions(new SearchSimilarJob()
                {
                    Position = Id,
                    HundredPercent = querystring100,
                    NinetyPercent = querystring90,
                    EightyPercent = querystring80,
                    SeventyPercent = querystring70,
                });
            }
            else
            {
                JobPosition.HundredPercent = querystring100;
                JobPosition.NinetyPercent = querystring90;
                JobPosition.EightyPercent = querystring80;
                JobPosition.SeventyPercent = querystring70;

                await _jobPositionService.UpdateSimilarPositions(JobPosition);
            }

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