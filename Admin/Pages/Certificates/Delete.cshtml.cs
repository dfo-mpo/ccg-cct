using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataModel;

namespace Admin.Pages.Certificates
{
    public class DeleteModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        public DeleteModel(DataModel.CctDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Certificate Certificate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Certificate = await _context.Certificates.FirstOrDefaultAsync(m => m.Id == id);

            if (Certificate == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Certificate = await _context.Certificates.FindAsync(id);

            if (Certificate != null)
            {
                _context.Certificates.Remove(Certificate);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
