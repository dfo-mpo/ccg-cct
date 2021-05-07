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

        public string CurrentFilter { get; set; }

        public IList<Competency> Competency { get; set; }

        public async Task OnGetAsync(string searchString)
        {
            CurrentFilter = searchString;

            IQueryable<Competency> competenciesIQ = from s in _context.Competencies
                                                    select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                competenciesIQ = competenciesIQ.Where(s => s.NameEng.Contains(searchString)
                                       || s.NameFre.Contains(searchString));
            }
                Competency = await competenciesIQ.AsNoTracking().ToListAsync();
            }
        }
    }
