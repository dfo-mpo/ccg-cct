using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Business.Dtos.JobGroups;
using System;
using System.Collections.Generic;

namespace Web.Pages.CCGMember
{
    public class AllPositionsModel : PageModel
    {
        private readonly ILogger<AllPositionsModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public JobGroupDto[] JobGroups { get; set; }   
        
        [BindProperty(SupportsGet = true)]
        public string Filter { get; set; }
        public List<string> EnglishGroups { get; set; } = new List<string>();
        public List<string> FrenchGroups { get; set; } = new List<string>();
        public AllPositionsModel(ILogger<AllPositionsModel> logger, JobGroupService jobcategoryService)
        {
            _logger = logger;
            _jobgroupService = jobcategoryService;
        }
        public async Task OnGetAsync()
        {
            _logger.LogInformation($"All positions page visited at {DateTime.UtcNow.ToLongTimeString()}");
            JobGroups = await _jobgroupService.GetJobGroups();
            foreach (var jobgroup in JobGroups)
            {
                var line = jobgroup.NameEng + ' ' + jobgroup.Code;
                var fline = jobgroup.NameFre + ' ' + jobgroup.Code;
                EnglishGroups.Add(line);
                FrenchGroups.Add(fline);
            }


        }

    }
}