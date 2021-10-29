using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using SmartBreadcrumbs.Attributes;

namespace Web.Pages.Student.HighSchool.Shoreside
{
    [Breadcrumb("Trades", FromPage = typeof(Shoreside.IndexModel))]
    public class TradesModel : PageModel
    {
        private readonly ILogger<TradesModel> _logger;
        private readonly JobGroupService _jobgroupService;
        public List<JobPositionDto> ShoreSidePositions = new List<JobPositionDto> { };
        [BindProperty(SupportsGet = true)]
        public string PositionIds { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ShoresidePositionIds { get; set; } = "&PositionId=";
        public TradesModel(ILogger<TradesModel> logger, JobGroupService jobgroupService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
        }
        public async Task OnGet(string positionids)
        {
            _logger.LogInformation($"High School Student Trades positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Shoreside
            
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
            
            //General Labour and Trades (GL-PCF)
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "PCF", "06"))
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
            
            //General Labour and Trades (GL-WOW)
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "WOW", "09"))
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