using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Admin.Data;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

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

        public bool DisplayTopOfPage { get; set; }

        public double LastTableContainerHeight { get; set; } = 300;

        public IList<JobPositionDto> JobPositions { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Filter { get; set; }

        public async Task OnGetAsync()
        {
            JobPositions = await _jobPositionService.GetAllJobPositions();

            DisplayTopOfPage = true;
            var sessionStr = HttpContext.Session.GetString("displayTopOfPage");
            if (!string.IsNullOrEmpty(sessionStr))
            {
                if (sessionStr.ToLower() == "false")
                {
                    DisplayTopOfPage = false;
                }
            }
            sessionStr = HttpContext.Session.GetString("lastTableContainerHeight");
            if (!string.IsNullOrEmpty(sessionStr))
            {
                if (double.TryParse(sessionStr, out double num))
                {
                    if (num > 300)
                    {
                        LastTableContainerHeight = num;
                    }
                }
            }
        }
    }
}

