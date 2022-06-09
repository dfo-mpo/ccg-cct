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

namespace Admin.Pages.Competencies
{
    public class ListModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;
        private readonly JobCompetencyService _jobCompetencyService;
        private static readonly int[] AccepetedTypeIds = { 1, 2, 3, 4 };

        public ListModel(DataModel.CctDbContext context, JobCompetencyService jobCompetencyService)
        {
            _context = context;
            _jobCompetencyService = jobCompetencyService;
        }
        [BindProperty(SupportsGet = true)]
        public string Filter { get; set; } 
        public JobCompetencyDto[] Competencies { get; set; }
        public JobCompetencyTypeDto Type { get; set; }

        public async Task OnGetAsync(int typeId)
        {
            if (!AccepetedTypeIds.Contains(typeId))
            {
                Type = await _jobCompetencyService.GetJobCompetencyTypeById(1);
                Competencies = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            }
            else { 
                Type = await _jobCompetencyService.GetJobCompetencyTypeById(typeId);
                Competencies = await _jobCompetencyService.GetJobCompetenciesByTypeId(typeId);
            }
        }
        public async Task OnPostAsync(int typeId)
        {
            if (typeId == 0 && !string.IsNullOrEmpty(Filter))
            {
                Type = await _jobCompetencyService.GetJobCompetencyTypeById(1);
                Competencies = await _jobCompetencyService.GetAllJobCompetencies();
            }
            else
            {
                Type = await _jobCompetencyService.GetJobCompetencyTypeById(typeId);
                Competencies = await _jobCompetencyService.GetJobCompetenciesByTypeId(typeId);
            }
        }
    }
}