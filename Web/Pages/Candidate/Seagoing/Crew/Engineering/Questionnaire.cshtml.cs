using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Candidate.Seagoing.Crew.Engineering
{
    public class QuestionnaireModel : PageModel
    {
        private readonly ILogger<QuestionnaireModel> _logger;
        private readonly JobPositionService _jobpositionService;
        public JobPositionDto[] Positions { get; set; }
        public QuestionnaireModel(ILogger<QuestionnaireModel> logger, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGet()
        {


            var  PositionIds = "PositionId=105&PositionId=106&PositionId=107";
                
            
            var parameters = String.Format($"{PositionIds}");
            _logger.LogInformation($"Similar positions list page visited at {DateTime.UtcNow.ToLongTimeString()}");
            Positions = await _jobpositionService.GetJobPositionByIdValues(parameters);
        }
    }
}