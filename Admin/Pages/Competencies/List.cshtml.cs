using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Business.Dtos.JobCompetencies;
using Admin.Data;
using Microsoft.AspNetCore.Http;

namespace Admin.Pages.Competencies
{
    public class ListModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly JobCompetencyService _jobCompetencyService;

        public ListModel(DataModel.CctDbContext context, JobCompetencyService jobCompetencyService)
        {
            _context = context;
            _jobCompetencyService = jobCompetencyService;
        }
        [BindProperty(SupportsGet = true)]
        public string Filter { get; set; }
        public JobCompetencyDto[] Competencies { get; set; }
        public JobCompetencyTypeDto Type { get; set; }

        public bool DisplayTopOfPage { get; set; }

        private async Task PreparePage(int typeId)
        {
            var accepetedTypeIds = _context.CompetencyTypes.Select(c => c.Id).ToList();

            if (!accepetedTypeIds.Contains(typeId))
            {
                Type = await _jobCompetencyService.GetJobCompetencyTypeById(1);
                Competencies = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            }
            else
            {
                Type = await _jobCompetencyService.GetJobCompetencyTypeById(typeId);
                Competencies = await _jobCompetencyService.GetJobCompetenciesByTypeId(typeId);
            }

            DisplayTopOfPage = true;
            var sessionStr = HttpContext.Session.GetString("displayTopOfPage");
            if (!string.IsNullOrEmpty(sessionStr))
            {
                if (sessionStr.ToLower() == "false")
                {
                    DisplayTopOfPage = false;
                }
            }
        }

        public async Task OnGetAsync(int typeId)
        {
            await PreparePage(typeId);
        }

        public async Task OnPostAsync(int typeId)
        {
            await PreparePage(typeId);
        }

    }
}