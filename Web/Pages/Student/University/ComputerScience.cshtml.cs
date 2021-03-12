using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Student.University
{
    public class ComputerScienceModel : PageModel
    {
        private readonly ILogger<ComputerScienceModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public List<JobPositionDto> ShoreSidePositions = new List<JobPositionDto> { };
        public List<JobPositionDto> SeagoingPositions = new List<JobPositionDto> { };
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }
        public ComputerScienceModel(ILogger<ComputerScienceModel> logger, JobGroupService jobgroupService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"University Student Computer Science positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Computer Systems CS-01 to CS-02
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(3, "01"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(3, "02"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }
        }
    }
}