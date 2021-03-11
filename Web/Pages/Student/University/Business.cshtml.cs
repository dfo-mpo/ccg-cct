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
    public class BusinessModel : PageModel
    {
        private readonly ILogger<BusinessModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public List<JobPositionDto> ShoreSidePositions = new List<JobPositionDto> { };
        public List<JobPositionDto> SeagoingPositions = new List<JobPositionDto> { };
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }
        public BusinessModel(ILogger<BusinessModel> logger, JobGroupService jobgroupService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"Seagoing Crew Engineering similar positions list page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Economics and Social Science Services EC-01 to EC-03
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(13, "01"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(13, "02"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(13, "03"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }

            //Programme Administration PM-03 to PM-04
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(20, "03"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(20, "04"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }

            //Administrative Services AS-02 to AS-03
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(2, "02"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(2, "03"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }
        }
    }
}