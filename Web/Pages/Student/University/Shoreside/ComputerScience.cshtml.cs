﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using SmartBreadcrumbs.Attributes;

namespace Web.Pages.Student.University.Shoreside
{
    [Breadcrumb("ComputerScience", FromPage = typeof(Shoreside.IndexModel))]
    public class ComputerScienceModel : PageModel
    {
        private readonly ILogger<ComputerScienceModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public List<JobPositionDto> ShoreSidePositions = new List<JobPositionDto> { };
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ShoresidePositionIds { get; set; } = "&PositionId=";
        public ComputerScienceModel(ILogger<ComputerScienceModel> logger, JobGroupService jobgroupService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"University Student Shoreside Computer Science positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Computer Systems CS-01 to CS-02
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(3, "01"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(3, "02"))
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