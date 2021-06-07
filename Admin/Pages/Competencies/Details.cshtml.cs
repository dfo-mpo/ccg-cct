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
    public class DetailsModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        private readonly JobCompetencyService _jobCompetencyService;

        public DetailsModel(DataModel.CctDbContext context, JobCompetencyService jobCompetencyService)
        {
            _context = context;
            _jobCompetencyService = jobCompetencyService;
        }
        public JobCompetencyDto Competency { get; set; }

        public async Task OnGetAsync(int id)
        {
            Competency = await _jobCompetencyService.GetJobCompetencyById(id);

            Competency.Level1DescEng =_jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 1).Result.CompetencyLevelReqDescEng;
            Competency.Level1DescFre = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 1).Result.CompetencyLevelReqDescFre;

            Competency.Level2DescEng = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 2).Result.CompetencyLevelReqDescEng;
            Competency.Level2DescFre = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 2).Result.CompetencyLevelReqDescFre;
         
            Competency.Level3DescEng = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 3).Result.CompetencyLevelReqDescEng;
            Competency.Level3DescFre = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 3).Result.CompetencyLevelReqDescFre;
        
            Competency.Level4DescEng = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 4).Result.CompetencyLevelReqDescEng;
            Competency.Level4DescFre = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 4).Result.CompetencyLevelReqDescFre;

            Competency.Level5DescEng = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 5).Result.CompetencyLevelReqDescEng;         
            Competency.Level5DescFre = _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(id, 5).Result.CompetencyLevelReqDescFre;

        }
    }
}
