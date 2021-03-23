using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataModel;

namespace Admin.Pages.Certificates
{
    public class CreateModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        public CreateModel(DataModel.CctDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Certificate Certificate { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Certificates.Add(Certificate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
