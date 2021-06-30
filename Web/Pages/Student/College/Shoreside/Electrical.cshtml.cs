using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.Student.College.Shoreside
{
    public class ElectricalModel : PageModel
    {
        private readonly ILogger<ElectricalModel> _logger;
        private readonly JobGroupService _jobgroupService;
        private readonly JobPositionService _jobpositionService;
        public List<JobPositionDto> ShoreSidePositions = new List<JobPositionDto> { };
        public string PositionIds { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ShoresidePositionIds { get; set; } = "&PositionId=";


        public ElectricalModel(ILogger<ElectricalModel> logger, JobGroupService jobgroupService, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGet()
        {
            _logger.LogInformation($"College Student Electrical positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Shoreside
            //All Engineering and Scientific Support EG
            foreach (var position in await _jobgroupService.GetJobPositionsByGroupId(6))
            {
                if (!position.Equals(null))
                {
                    ShoresidePositionIds += String.Format($"&PositionId={position.JobTitleId}");
                    ShoreSidePositions.Add(position);
                }
            }

            //General Labor and Trades EIM-10
            foreach (var position in await _jobgroupService.GetJobGroupPositionsBySubGroupLevel(8, "EIM", "10"))
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