using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.CCGMember.Similar
{
    public class SimilarListModel : PageModel
    {
        private readonly ILogger<SimilarListModel> _logger;
        private readonly SimilarService _similarService;
        public List<JobPositionDto> Positions { get; set; } = new List<JobPositionDto>();
        public SimilarListModel(ILogger<SimilarListModel> logger, SimilarService similarService)
        {
            _logger = logger;
            _similarService = similarService;
        }
        public async Task OnGet(string id)
        {
            _logger.LogInformation($"Similar positions list page visited at {DateTime.UtcNow.ToLongTimeString()}");
            var similarpositions = await _similarService.GetAllSimilarJobPositionsByPositionId(id);
            foreach (var p in similarpositions)
            {
                var pdto = await _similarService.GetJobPositionById(p.JobTitleId);
                if (!pdto.Equals(null)) {
                Positions.Add(pdto);
                }
            }         
        }
    }
}