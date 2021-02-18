using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Dtos.JobGroups;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Candidate.Shoreside
{
    public class AllCandidateShoresideModel : PageModel
    {
        private readonly ILogger<AllCandidateShoresideModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public JobGroupDto[] JobGroups { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Filter { get; set; }
        public AllCandidateShoresideModel(ILogger<AllCandidateShoresideModel> logger, JobGroupService jobcategoryService)
        {
            _logger = logger;
            _jobgroupService = jobcategoryService;
        }
        public async Task OnGetAsync()
        {
            _logger.LogInformation($"All positions page visited at {DateTime.UtcNow.ToLongTimeString()}");
            JobGroups = await _jobgroupService.GetJobGroups();
        }
    }
}