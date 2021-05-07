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
            var emptyCertificate = new Certificate();

            if (await TryUpdateModelAsync<Certificate>(
                emptyCertificate,
                "certificate",   // Prefix for form value.
                s => s.NameEng, s => s.NameFre, s => s.DescEng, s => s.DescFre))
            {
                _context.Certificates.Add(emptyCertificate);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return Page();
        }
        
    }
}
