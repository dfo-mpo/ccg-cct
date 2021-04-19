using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataModel;

namespace Admin.Pages.Competencies.Knowledge
{
    public class DetailsModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        public DetailsModel(DataModel.CctDbContext context)
        {
            _context = context;
        }

        public Competency Competency { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Competency = await _context.Competencies.FirstOrDefaultAsync(m => m.Id == id);

            if (Competency == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
