﻿using System;
using System.Collections.Generic;
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
        [BindProperty(SupportsGet = true)]
        public string ShoresidePositionIds { get; set; } = "&PositionId=";
        [BindProperty(SupportsGet = true)]
        public string SeagoingPositionIds { get; set; } = "&PositionId=";
        public TradesModel(ILogger<TradesModel> logger, JobGroupService jobgroupService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGet(string positionids)
        {
            _logger.LogInformation($"High School Student Trades positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Shoreside
            //General Labour and Trades (GL-COI)
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "COI", "09"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "COI", "10"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "COI", "11"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }

            //General Labour and Trades (GL-EIM)
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "EIM", "10"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "EIM", "11"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }

            //General Labour and Trades (GL-MAM)
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "MAM", "09"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "MAM", "10"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "MAM", "11"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }

            //General Labour and Trades (GL-MAN)
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "MAN", "05"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "MAN", "06"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "MAN", "07"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "MAN", "08"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "MAN", "09"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "MAN", "10"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            //General Labour and Trades (GL-MDO)
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "MDO", "03"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "MDO", "04"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "MDO", "05"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "MDO", "06"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "MDO", "07"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            //General Labour and Trades (GL-MOC)
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "MOC", "05"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "MOC", "07"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            //General Labour and Trades (GL-PCF)
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "PCF", "06"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "PCF", "07"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "PCF", "08"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            //General Labour and Trades (GL-PRW)
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "PRW", "08"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "PRW", "09"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "PRW", "10"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "PRW", "11"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            //General Labour and Trades (GL-VHE)
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "VHE", "10"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            //General Labour and Trades (GL-WOW)
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "WOW", "09"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "WOW", "10"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }

            //General Services FOS-02
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(4, "FOS", "02"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }

            //General Technician GT-01 to GT-03
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(1, "01"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(1, "02"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(1, "03"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }

            //Lightkeepers LI-03
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(5, "03"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }

            //Purchasing and Supply PG-01
            foreach (var position in await _jobgroupService.GetJobGroupPositionsByLevel(7, "01"))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }

            //Seagoing
            //Ship's Crew DED-02
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(9, "DED", "02"))
            {
                if (!position.Equals(null))
                {
                    SeagoingPositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    SeagoingPositions.Add(position);
                }
            }
            //Ship's Crew ERD-03
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(9, "ERD", "03"))
            {
                if (!position.Equals(null))
                {
                    SeagoingPositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    SeagoingPositions.Add(position);
                }
            }
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