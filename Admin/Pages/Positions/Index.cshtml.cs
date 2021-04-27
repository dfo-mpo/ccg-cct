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
    public class IndexModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        public IndexModel(DataModel.CctDbContext context)
        {
            _context = context;
        }

        public IList<JobPosition> JobPosition { get; set; }

        public async Task OnGetAsync()
        {
            JobPosition = await _context.JobPositions.ToListAsync();
        }
    }
}
