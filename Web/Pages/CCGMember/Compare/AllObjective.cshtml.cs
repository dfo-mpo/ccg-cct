using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Microsoft.AspNetCore.Routing;

namespace Web.Pages.CCGMember.Compare
{
    public class AllObjectiveModel : PageModel
    {
        //private readonly ILogger<AllPositionsModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public JobGroup[] JobGroups { get; set; }   
        
        [BindProperty(SupportsGet = true)]
        public string filter { get; set; }
        public AllObjectiveModel(ILogger<AllObjectiveModel> logger, JobGroupService jobgroupService)
        {
            //_logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGetAsync()
        {
            JobGroups = await _jobgroupService.GetJobGroups();
        }

    }
}