using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Student.University
{
    public class SciencesModel : PageModel
    {
        private readonly ILogger<SciencesModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public List<JobPositionDto> ShoreSidePositions = new List<JobPositionDto> { };
        public List<JobPositionDto> SeagoingPositions = new List<JobPositionDto> { };
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }
        public SciencesModel(ILogger<SciencesModel> logger, JobGroupService jobgroupService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"University Student Sciences positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Ship's Officer MAO-02 to MAO-03
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(10, "MAO-02"))
            {
                if (!position.Equals(null))
                {
                    SeagoingPositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(10, "MAO-03"))
            {
                if (!position.Equals(null))
                {
                    SeagoingPositions.Add(position);
                }
            }
        }
    }
}