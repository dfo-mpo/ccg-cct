using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.CCGMember
{
    public class DetailsModel : PageModel
    {
        private readonly JobPositionService _jobpositionService;
        [BindProperty(SupportsGet = true)]
        public string id { get; set; }
        [BindProperty(SupportsGet = true)]
        public int positionid { get; set; }
        [BindProperty(SupportsGet = true)]
        public string level { get; set; }
        public JobPosition curposition { get; set; }
        public JobCertificate[] curcertificates { get; set; }
        public JobCompetencyRating[] curratings1 { get; set; }
        public JobCompetencyRating[] curratings2 { get; set; }
        public JobCompetencyRating[] curratings3 { get; set; }

        public DetailsModel(ILogger<DetailsModel> logger, JobPositionService jobcompetencyService)
        {
            //_logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGetAsync(int positionid)
        {
            curposition = await _jobpositionService.GetJobPosition(positionid);
            curcertificates = await _jobpositionService.GetJobCertificatesById(positionid);           
            curratings1 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(positionid, 1);
            curratings2 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(positionid, 2);
            curratings3 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(positionid, 3);
        }
        }

    }

