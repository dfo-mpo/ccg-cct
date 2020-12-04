using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Business.Dtos.JobGroups;

namespace Web.Pages.CCGMember
{
    public class AllPositionsModel : PageModel
    {
        //private readonly ILogger<AllPositionsModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public JobGroupDto[] JobGroups { get; set; }   
        
        [BindProperty(SupportsGet = true)]
        public string Filter { get; set; }
        public AllPositionsModel(ILogger<AllPositionsModel> logger, JobGroupService jobcategoryService)
        {
            //_logger = logger;
            _jobgroupService = jobcategoryService;
        }
        public async Task OnGetAsync()
        {
            JobGroups = await _jobgroupService.GetJobGroups();
        }

    }
}