using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Admin.Data;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Microsoft.AspNetCore.Http;
using Business.Dtos.JobCompetencies;

namespace Admin.Pages.Certificates.Descriptions
{
    public class LocateModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        private readonly JobPositionService _jobPositionService;
        private readonly JobCompetencyService _jobCompetencyService;
        private readonly JobCertificateService _jobCertificateService;

        public LocateModel(DataModel.CctDbContext context, JobPositionService jobPositionService, JobCompetencyService jobCompetencyService, JobCertificateService jobCertificateService)
        {
            _context = context;
            _jobPositionService = jobPositionService;
            _jobCompetencyService = jobCompetencyService;
            _jobCertificateService = jobCertificateService;
        }
        [BindProperty(SupportsGet = true)]
        public string Filter { get; set; }
        public IList<JobCertificateDto> Descriptions { get; set; }

        public bool DisplayTopOfPage { get; set; }

        public bool LocatingADescription { get; set; } = false;

        public double LastTableContainerHeight { get; set; } = 300;

        public CertificateDescription DescriptionBeingLocated { get; set; }

        public Dictionary<JobPositionDto, List<JobCertificateDto>> PositionsThatHaveTheCertificateDesc { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            DisplayTopOfPage = true;
            var sessionStr = HttpContext.Session.GetString("displayTopOfPage");
            if (!string.IsNullOrEmpty(sessionStr))
            {
                if (sessionStr.ToLower() == "false")
                {
                    DisplayTopOfPage = false;
                }
            }
            sessionStr = HttpContext.Session.GetString("lastTableContainerHeight");
            if (!string.IsNullOrEmpty(sessionStr))
            {
                if (double.TryParse(sessionStr, out double num))
                {
                    if (num > 300)
                    {
                        LastTableContainerHeight = num;
                    }
                }
            }

            Descriptions = await _jobCertificateService.GetAllJobCertificateDescriptions();

            if (id != null)
            {
                try
                {
                    DescriptionBeingLocated = await _context.CertificateDescriptions.FindAsync(id.Value);
                }
                catch
                {
                    DescriptionBeingLocated = null;
                }

                if (DescriptionBeingLocated != null)
                {
                    if (DescriptionBeingLocated.Active == 1)
                    {
                        LocatingADescription = true;
                    }
                }
            }

            if (LocatingADescription)
            {
                var activePositions = (await _jobPositionService.GetAllJobPositions()).Where(x => x.Active == 1).ToList();
                int idToFind = id.Value;

                PositionsThatHaveTheCertificateDesc = new Dictionary<JobPositionDto, List<JobCertificateDto>>();

                foreach (var pos in activePositions)
                {
                    var positionCerts = await _jobCompetencyService.GetJobCertificatesById(pos.JobTitleId);
                    var certsWithMatchingDesc = new List<JobCertificateDto>();

                    foreach (var cert in positionCerts)
                    {
                        if (cert.Active == 1)
                        {
                            if (cert.CertificateDescId == idToFind)
                            {
                                certsWithMatchingDesc.Add(cert);
                            }
                        }
                    }
                    if (certsWithMatchingDesc.Any())
                    {
                        PositionsThatHaveTheCertificateDesc.Add(pos, certsWithMatchingDesc);
                    }
                }
            }

            return Page();
        }
    }
}
