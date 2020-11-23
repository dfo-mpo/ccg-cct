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
        public int positionId { get; set; }

        [BindProperty(SupportsGet = true)]
        public int obj { get; set; }
        public JobPosition curposition { get; set; }
        public JobPosition objposition { get; set; }
        public JobCertificate[] curcertificates { get; set; }
        public JobCertificate[] objcertificates { get; set; }
        public JobCompetencyRating[] curratings { get; set; }
        public JobCompetencyRating[] objratings { get; set; }
        [BindProperty]
        public List<JobCompetencyRating> matchingcomp { get; set; }
        [BindProperty]
        public List<SharedJobCompetencyRating> diffcomp { get; set; }
        [BindProperty]
        public List<JobCertificate> matchcert { get; set; }
        [BindProperty]
        public List<JobCertificate> diffcert { get; set; }
        public DetailsModel(ILogger<DetailsModel> logger, JobPositionService jobcompetencyService)
        {
            //_logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGetAsync(int positionid)
        {
            curcertificates = await _jobpositionService.GetJobCertificatesById(positionid);
            curposition = await _jobpositionService.GetJobPosition(positionid);
            curratings = await _jobpositionService.GetJobCompetencyRatings(positionid);

            }
        }

    }

