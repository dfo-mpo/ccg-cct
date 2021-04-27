using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataModel;

namespace Admin.Pages.Positions
{
    public class DetailsModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        public DetailsModel(DataModel.CctDbContext context)
        {
            _context = context;
        }

        public JobPosition JobPosition { get; set; }
       
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JobPosition = await _context.JobPositions.FirstOrDefaultAsync(m => m.Id == id);

            if (JobPosition == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
