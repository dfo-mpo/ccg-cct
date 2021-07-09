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
    [Breadcrumb("Logistics", FromPage = typeof(Seagoing.IndexModel))]
    public class SeagoingLogisticsModel : PageModel
    {
        private readonly ILogger<SeagoingLogisticsModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public List<JobPositionDto> SeagoingPositions = new List<JobPositionDto> { };
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SeagoingPositionIds { get; set; } = "&PositionId=";
        public SeagoingLogisticsModel(ILogger<SeagoingLogisticsModel> logger, JobGroupService jobgroupService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"HighSchool Student Seagoing Logistics positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Seagoing
            //Ship's Crew STD-01
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(9, "STD", "01"))
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
