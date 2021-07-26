using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Business.Dtos.JobGroups;
using Business.Dtos.JobPositions;

namespace Web.Pages.CCGMember.Compare
{
    public class ObjectivePositionModel : PageModel
    {
        private readonly ILogger<ObjectivePositionModel> _logger;
        private readonly JobGroupService _jobcategoryService;
        public JobGroupDto JobGroup { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public int HLId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string IdObj { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string Level { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string LevelObj { get; set; }
        [BindProperty(SupportsGet = true)]
        public string LevelCode { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string LevelCodeObj { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string SubGroupCode { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SubGroupCodeObj { get; set; }
        [BindProperty(SupportsGet = true)]
        public JobPositionDto ObjectivePosition { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ObjectiveId { get; set; } = null;
        public JobGroupPositionDto[] JobGroupLevels { get; set; }
        public JobPositionDto[] JobGroupPositions { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PreviousPage { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PreviousPageDetails { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PreviousPageCompare { get; set; }
        public ObjectivePositionModel(ILogger<ObjectivePositionModel> logger, JobGroupService jobcategoryService)
        {
            _logger = logger;
            _jobcategoryService = jobcategoryService;
        }
        public async Task OnGetAsync(int idobj, string levelobj, string subgroupcodeobj, int objectiveid)
        {
            _logger.LogInformation($"Objective positions page visited at {DateTime.UtcNow.ToLongTimeString()}");
            JobGroup = await _jobcategoryService.GetJobGroupById(idobj);
            JobGroupLevels = await _jobcategoryService.GetSubGroupLevelsByGroupId(idobj);
            JobGroupPositions = string.IsNullOrEmpty(subgroupcodeobj) ? await _jobcategoryService.GetJobGroupPositionsByLevel(idobj, levelobj) : await _jobcategoryService.GetJobGroupPositionsBySubGroupLevel(idobj, subgroupcodeobj, levelobj);
            ObjectivePosition = objectiveid==0 ? null : await _jobcategoryService.GetJobPositionById(objectiveid);           
        }
    }
}
