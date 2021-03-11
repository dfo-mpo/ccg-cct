using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Student.HighSchool
{
    public class TradesModel : PageModel
    {
        private readonly ILogger<TradesModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public List<JobPositionDto> ShoreSidePositions = new List<JobPositionDto> { };
        public List<JobPositionDto> SeagoingPositions = new List<JobPositionDto> { };
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }
        public TradesModel(ILogger<TradesModel> logger, JobGroupService jobgroupService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGet(string positionids)
        {
            _logger.LogInformation($"Seagoing Crew Engineering similar positions list page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Shoreside
            //All General Labour and Trades (GL)
            foreach (var position in await _jobgroupService.GetJobPositionsByGroupId(8))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }

            //Purchasing and Supply PG-01
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(7, "01"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }

            //General Technician GT-01 to GT-03
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(1, "01"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(1, "02"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(1, "03"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }

            //General Services FOS-02
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(4, "FOS-02"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(5, "03"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }

            //Seagoing
            //Ship's Crew DED-02
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(9, "DED-02"))
            {
                if (!position.Equals(null))
                {
                    SeagoingPositions.Add(position);
                }
            }
            //Ship's Crew ERD-03
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(9, "ERD-03"))
            {
                if (!position.Equals(null))
                {
                    SeagoingPositions.Add(position);
                }
            }
            //Ship's Crew STD-01
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(9, "STD-01"))
            {
                if (!position.Equals(null))
                {
                    SeagoingPositions.Add(position);
                }
            }
        }
    }
}