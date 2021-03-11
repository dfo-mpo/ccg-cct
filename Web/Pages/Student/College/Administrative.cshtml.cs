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
    public class AdministrativeModel : PageModel
    {
        private readonly ILogger<AdministrativeModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public List<JobPositionDto> ShoreSidePositions = new List<JobPositionDto> { };
        public List<JobPositionDto> SeagoingPositions = new List<JobPositionDto> { };
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }
        public AdministrativeModel(ILogger<AdministrativeModel> logger, JobGroupService jobgroupService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"Seagoing Crew Engineering similar positions list page visited at {DateTime.UtcNow.ToLongTimeString()}");       

            //Clerical and Regulatory CR-04
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(12, "04"))
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

            //Office Equipement OE-01 to OE-02
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(19, "01"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(19, "02"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }
        }
    }
}