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

        public ListModel(DataModel.CctDbContext context, JobCompetencyService jobCompetencyService)
        {
            _context = context;
            _jobCompetencyService = jobCompetencyService;
        }

        public string CurrentFilter { get; set; }

        public JobCompetencyDto[] Competencies { get; set; }
        public JobCompetencyTypeDto Type { get; set; }

        public async Task OnGetAsync(int typeId)
        {
            Type = await _jobCompetencyService.GetJobCompetencyTypeById(typeId);
            Competencies = await _jobCompetencyService.GetJobCompetenciesByTypeId(typeId);         

        }
    }
}