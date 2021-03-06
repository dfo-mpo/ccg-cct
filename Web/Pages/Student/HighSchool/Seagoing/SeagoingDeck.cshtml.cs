using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using SmartBreadcrumbs.Attributes;

namespace Web.Pages.Student.HighSchool.Seagoing
{
    [Breadcrumb("Deck", FromPage = typeof(Seagoing.IndexModel))]
    public class SeagoingDeckModel : PageModel
    {
        private readonly ILogger<SeagoingDeckModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public List<JobPositionDto> SeagoingPositions = new List<JobPositionDto> { };
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SeagoingPositionIds { get; set; } = "&PositionId=";
        public SeagoingDeckModel(ILogger<SeagoingDeckModel> logger, JobGroupService jobgroupService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"High School Student Seagoing Deck positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Seagoing
            //Ship's Crew DED-02 (deck)
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(9, "DED", "02"))
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