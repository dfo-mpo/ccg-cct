using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using SmartBreadcrumbs.Attributes;

namespace Web.Pages.Student.College.Shoreside
{
    [Breadcrumb("Geographical", FromPage = typeof(Shoreside.IndexModel))]
    public class GeographicalInformationModel : PageModel
    {
        private readonly ILogger<GeographicalInformationModel> _logger;
        private readonly JobGroupService _jobgroupService;
        private readonly JobPositionService _jobpositionService;

        public string PositionIds { get; set; }
        [BindProperty(SupportsGet = true)]

        public JobPositionDto[] ShoreSidePositions { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ShoresidePositionIds { get; set; }
        public GeographicalInformationModel(ILogger<GeographicalInformationModel> logger, JobGroupService jobgroupService, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobgroupService = jobgroupService;
            _jobpositionService = jobcompetencyService;
        }

        public async Task OnGet()
        {
            _logger.LogInformation($"College Student Geographical Information positions page visited at {DateTime.UtcNow.ToLongTimeString()}");

            //Shoreside
            //Student Geo Info 
            ShoresidePositionIds = "&PositionId=255&PositionId=256&PositionId=258&PositionId=259";
            ShoreSidePositions = await _jobpositionService.GetJobPositionByIdValues(ShoresidePositionIds);
        }
    }
}