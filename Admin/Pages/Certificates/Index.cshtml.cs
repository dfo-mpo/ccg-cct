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
    public class IndexModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        public IndexModel(DataModel.CctDbContext context)
        {
            _context = context;
        }

        public IList<Certificate> Certificate { get;set; }

        public async Task OnGetAsync()
        {
            Certificate = await _context.Certificates.ToListAsync();
        }
    }
}
