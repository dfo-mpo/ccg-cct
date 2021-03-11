﻿using System;
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
    public class CookModel : PageModel
    {
        private readonly ILogger<CookModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public List<JobPositionDto> ShoreSidePositions = new List<JobPositionDto> { };
        public List<JobPositionDto> SeagoingPositions = new List<JobPositionDto> { };
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }
        public CookModel(ILogger<CookModel> logger, JobGroupService jobgroupService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"Seagoing Crew Engineering similar positions list page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Shoreside
            //General Services GS-02
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(4, "FOS-02"))
            {
                if (!position.Equals(null))
                {
                    ShoreSidePositions.Add(position);
                }
            }

            //Seagoing
            //Ship's Crew STD-01
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(9, "STD-01"))
            {
                if (!position.Equals(null))
                {
                    SeagoingPositions.Add(position);
                }
            }
            //Ship's Crew STD-03
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