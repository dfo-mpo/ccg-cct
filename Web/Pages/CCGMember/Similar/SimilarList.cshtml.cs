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
        private readonly JobPositionService _jobpositionService;
        public JobPositionDto[] Positions1 { get; set; }
        public JobPositionDto[] Positions2 { get; set; }
        public JobPositionDto[] Positions3 { get; set; }
        public List<JobPositionDto> Positions { get; set; } = new List<JobPositionDto> { };
        public IEnumerable<int> SimilarPositions1 { get; set; }
        public IEnumerable<int> SimilarPositions2 { get; set; }
        public IEnumerable<int> SimilarPositions3 { get; set; }
        public IEnumerable<int> SimilarPositions { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string id { get; set; }
        public SimilarListModel(ILogger<SimilarListModel> logger, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGet(string id)
        {
            PositionId = Int32.Parse(id.Split('!')[0]);
            var rest = id.Split('!')[1].Split('#');
            var r = rest[0].Split('%')[0].Split('-');
            var r2 = rest[1].Split('%')[0];
            var r3 = rest[2].Split('%');


            Positions1 = await _jobpositionService.GetAllSimilarPositionsByPositionId(PositionId, 1);
            Positions2 = await _jobpositionService.GetAllSimilarPositionsByPositionId(PositionId, 2);
            Positions3 = await _jobpositionService.GetAllSimilarPositionsByPositionId(PositionId, 3);
            SimilarPositions1 = Positions1.Select(e => e.JobTitleId).ToList().Distinct();
            SimilarPositions2 = Positions2.Select(e => e.JobTitleId).ToList().Distinct();
            SimilarPositions3 = Positions3.Select(e => e.JobTitleId).ToList().Distinct();
            SimilarPositions = SimilarPositions1.Intersect(SimilarPositions2).Intersect(SimilarPositions3);
            foreach (var i in SimilarPositions)
            {
                var position = await _jobpositionService.GetJobPositionById(i);
                if (!(position.Equals(null)))
                {
                    Positions.Add(position);
                }
            }
        }
    }
}