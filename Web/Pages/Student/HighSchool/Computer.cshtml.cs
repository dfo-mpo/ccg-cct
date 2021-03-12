using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Student.HighSchool
{
    public class ComputerModel : PageModel
    {
        private readonly ILogger<ComputerModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public List<JobPositionDto> ShoreSidePositions = new List<JobPositionDto> { };
        public List<JobPositionDto> SeagoingPositions = new List<JobPositionDto> { };
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }
        public ComputerModel(ILogger<ComputerModel> logger, JobGroupService jobgroupService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"High School Student Computer positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Computer Systems CS-01
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(3, "01"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }

            //Radio Operators RO-03
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(21, "03"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }
        }
    }
}