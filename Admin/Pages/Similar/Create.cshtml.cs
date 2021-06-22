using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Admin.Data;
using Microsoft.Extensions.Logging;
using Business.Dtos.JobPositions;

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
        [BindProperty]
        public SearchSimilarJob JobPosition { get; set; }
        public JobPositionDto[] AllJobPositions { get; set; }
        public JobPositionDto[] AddedPositionsHundredPercent { get; set; }
        public string AddedPositionsHundredPercentIds = string.Empty;
        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JobPosition = await _context.SearchSimilarJobs.FirstOrDefaultAsync(m => m.Position == id);
            AddedPositionsHundredPercent = await _jobPositionService.GetJobPositionByIdValues(AddedPositionsHundredPercentIds);
            AllJobPositions = await _jobPositionService.GetAllJobPositions();
            if (JobPosition == null)
            {
                JobPosition = new SearchSimilarJob()
                {
                    Position = id,
                    HundredPercent = string.Empty,
                    NinetyPercent = string.Empty,
                    EightyPercent = string.Empty,
                    SeventyPercent = string.Empty,
                };
                
                return Page();
            }
            return RedirectToPage("Edit");
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                _jobPositionService.PostSimilarPositions(JobPosition);
                //await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobPositionExists(JobPosition.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("Index");
        }
        public async Task OnPostHundredPercentPosition(int positionid)
        {
            AllJobPositions = await _jobPositionService.GetAllJobPositions();
            AddedPositionsHundredPercentIds += "&PositionId=" + positionid;
            AddedPositionsHundredPercent = await _jobPositionService.GetJobPositionByIdValues(AddedPositionsHundredPercentIds);

        }
        public async Task OnPostDeleteHundredPercentPosition(int deleteid) {

            AllJobPositions = await _jobPositionService.GetAllJobPositions();
        }

        private bool JobPositionExists(int id)
        {

            return _context.JobPositions.Any(e => e.Id == id);
        }
    }
}