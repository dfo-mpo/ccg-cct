using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Student.College
{
    public class ElectricalModel : PageModel
    {
        private readonly ILogger<ElectricalModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public List<JobPositionDto> ShoreSidePositions = new List<JobPositionDto> { };
        public List<JobPositionDto> SeagoingPositions = new List<JobPositionDto> { };
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }
        public ElectricalModel(ILogger<ElectricalModel> logger, JobGroupService jobgroupService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"College Student Electrical positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Shoreside
            //Engineering and Scientific Support EG-02 to EG-05
            foreach (var position in await _jobgroupService.GetJobPositionsByGroupId(6))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }

            //General Labor and Trades EIM-10
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(8, "EIM-10"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }

            //Seagoing
            //Ship's Officer MAO-05
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(10, "MAO-05"))
            {
                if (!position.Equals(null))
                {
                    SeagoingPositions.Add(position);
                }
            }
        }
    }
}