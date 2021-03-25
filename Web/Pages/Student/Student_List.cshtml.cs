using System;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Student
{
    public class Student_ListModel : PageModel
    {
        private readonly ILogger<Student_ListModel> _logger;
        private readonly JobPositionService _jobpositionService;
        public JobPositionDto[] Positions { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }
        public Student_ListModel(ILogger<Student_ListModel> logger, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGet()
        {
            PositionIds = "PositionId=105&PositionId=106&PositionId=107";
            _logger.LogInformation($"Seagoing Crew Engineering similar positions list page visited at {DateTime.UtcNow.ToLongTimeString()}");
            Positions = await _jobpositionService.GetJobPositionByIdValues(PositionIds);
        }
    }
}
