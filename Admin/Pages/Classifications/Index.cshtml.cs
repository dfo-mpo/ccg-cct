using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Data;
using Business.Dtos.JobGroups;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.Pages.Classifications
{
    public class IndexModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        private readonly JobGroupService _jobGroupService;
        public JobGroupDto[] JobGroups { get; set; }

        public IndexModel(DataModel.CctDbContext context, JobGroupService jobGroupService)
        {
            _context = context;
            _jobGroupService = jobGroupService;
        }
        public async Task OnGetAsync()
        {
            JobGroups = await _jobGroupService.GetJobGroups();
        }
    }
}