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
    public class IndexModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        public IndexModel(DataModel.CctDbContext context)
        {
            _context = context;
        }

        public IList<Competency> Competency { get; set; }

        public async Task OnGetAsync()
        {
            Competency = await _context.Competencies.ToListAsync();
        }
    }
}
