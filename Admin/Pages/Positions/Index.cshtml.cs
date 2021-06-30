using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Admin.Data;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Pages.Positions
{
    public class IndexModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        private readonly JobPositionService _jobPositionService;

        public IndexModel(DataModel.CctDbContext context, JobPositionService jobPositionService)
        {
            _context = context;
            _jobPositionService = jobPositionService;
        }

        public IList<JobPositionDto> JobPositions { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Filter { get; set; }

        public async Task OnGetAsync()
        {
            JobPositions = await _jobPositionService.GetAllJobPositions();
        }
    }
}

