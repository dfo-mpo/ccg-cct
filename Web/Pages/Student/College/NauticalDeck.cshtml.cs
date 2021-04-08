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
    public class NauticalDeckModel : PageModel
    {
        private readonly ILogger<NauticalDeckModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public List<JobPositionDto> ShoreSidePositions = new List<JobPositionDto> { };
        public List<JobPositionDto> SeagoingPositions = new List<JobPositionDto> { };
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ShoresidePositionIds { get; set; } = "&PositionId=";
        [BindProperty(SupportsGet = true)]
        public string SeagoingPositionIds { get; set; } = "&PositionId=";
        public NauticalDeckModel(ILogger<NauticalDeckModel> logger, JobGroupService jobgroupService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"College Student Nautical Deck positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Seagoing
            //Ship's Officer MAO-02 to MAO-03
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(10, "MAO-02"))
            {
                if (!position.Equals(null))
                {
                    SeagoingPositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    SeagoingPositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(10, "MAO-03"))
            {
                if (!position.Equals(null))
                {
                    SeagoingPositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    SeagoingPositions.Add(position);
                }
            }
        }
    }
}