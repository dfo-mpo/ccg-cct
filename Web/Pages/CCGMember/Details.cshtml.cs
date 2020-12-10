using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Business.Dtos.JobPositions;
using Business.Dtos.JobCompetencies;



namespace Web.Pages.CCGMember
{
    public class DetailsModel : PageModel
    {
        private readonly JobPositionService _jobpositionService;
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Level { get; set; }
        public JobPositionDto Position { get; set; }
        public JobCertificateDto[] PositionCertificates { get; set; }
        public JobCompetencyRatingDto[] PositionRatings1 { get; set; }
        public JobCompetencyRatingDto[] PositionRatings2 { get; set; }
        public JobCompetencyRatingDto[] PositionRatings3 { get; set; }

        public DetailsModel(ILogger<DetailsModel> logger, JobPositionService jobcompetencyService)
        {
            //_logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGetAsync(int positionid)
        {
            Position = await _jobpositionService.GetJobPositionById(positionid);
            PositionCertificates = await _jobpositionService.GetJobCertificatesById(positionid);
            PositionRatings1 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(positionid, 1);
            PositionRatings2 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(positionid, 2);
            PositionRatings3 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(positionid, 3);
        }
        }

    }

