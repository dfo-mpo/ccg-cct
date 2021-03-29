using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Student.College
{
    public class ElectronicsModel : PageModel
    {
        private readonly ILogger<ElectronicsModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public List<JobPositionDto> ShoreSidePositions = new List<JobPositionDto> { };
        public List<JobPositionDto> SeagoingPositions = new List<JobPositionDto> { };
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ShoresidePositionIds { get; set; } = "&PositionId=";
        [BindProperty(SupportsGet = true)]
        public string SeagoingPositionIds { get; set; } = "&PositionId=";
        public ElectronicsModel(ILogger<ElectronicsModel> logger, JobGroupService jobgroupService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"Seagoing Crew Engineering similar positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Architecture, Engineering ENG-02
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(11, "02"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }

            //Engineering and Scientific Support EG-02 to EG-05
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(6, "02"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(6, "03"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(6, "04"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(6, "05"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
        }
    }
}