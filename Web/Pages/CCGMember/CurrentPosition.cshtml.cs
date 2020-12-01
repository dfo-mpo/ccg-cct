using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Data.Classes.JobGroups;
using Data.Classes.JobPositions;

namespace Web.Pages.CCGMember
{
    public class CurrentPositionModel : PageModel
    {
        private readonly JobGroupService _jobcategoryService;
        public JobGroupDto JobGroup { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Level { get; set; }

        public JobGroupPositionDto[] JobGroupLevels { get; set; }
        public JobPositionDto[] JobGroupPositions { get; set; }

        public  CurrentPositionModel(ILogger<CurrentPositionModel> logger, JobGroupService jobcategoryService)
        {
            //_logger = logger;
            _jobcategoryService = jobcategoryService;
        }
        public async Task OnGetAsync(int id, int level)
        {
            JobGroup = await _jobcategoryService.GetJobGroupById(id);
            JobGroupLevels = await _jobcategoryService.GetJobGroupPositionsById(id);
            JobGroupPositions = await _jobcategoryService.GetJobGroupPositionsByLevel(id, level);    
        }

    }
}
