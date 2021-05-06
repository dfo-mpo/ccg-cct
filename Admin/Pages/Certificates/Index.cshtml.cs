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

        public string CurrentFilter { get; set; }

        public IList<Certificate> Certificates { get;set; }

        public async Task OnGetAsync(string searchString)
        {
            CurrentFilter = searchString;

            IQueryable<Certificate> certificatesIQ = from s in _context.Certificates
                                             select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                certificatesIQ = certificatesIQ.Where(s => s.NameEng.Contains(searchString)
                                       || s.NameFre.Contains(searchString));
            }
            
            Certificates = await certificatesIQ.AsNoTracking().ToListAsync();
        }
    }
}
