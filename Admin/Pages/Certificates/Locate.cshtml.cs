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

namespace Admin.Pages.Certificates
{
    public class LocateModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        private readonly JobPositionService _jobPositionService;
        private readonly JobCompetencyService _jobCompetencyService;

        public LocateModel(DataModel.CctDbContext context, JobPositionService jobPositionService, JobCompetencyService jobCompetencyService)
        {
            _context = context;
            _jobPositionService = jobPositionService;
            _jobCompetencyService = jobCompetencyService;
        }
        [BindProperty(SupportsGet = true)]
        public string Filter { get; set; }
        public IList<JobCertificateDto> Certificates { get; set; }

        public bool DisplayTopOfPage { get; set; }

        public double LastTableContainerHeight { get; set; } = 300;

        public bool LocatingACertificate { get; set; } = false;

        public JobCertificateDto CertificateBeingLocated { get; set; }

        public Dictionary<JobPositionDto, JobCertificateDto> PositionsThatHaveTheCertificate { get; set; }

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

            Certificates = await _jobCompetencyService.GetJobCertificates();

            if (id != null)
            {
                try
                {
                    CertificateBeingLocated = await _jobCompetencyService.GetJobCertificateById(id.Value);
                }
                catch
                {
                    CertificateBeingLocated = null;
                }

                if (CertificateBeingLocated != null)
                {
                    if (CertificateBeingLocated.Active == 1)
                    {
                        LocatingACertificate = true;
                    }
                }
            }

            if (LocatingACertificate)
            {
                var activePositions = (await _jobPositionService.GetAllJobPositions()).Where(x => x.Active == 1).ToList();
                int idToFind = id.Value;

                PositionsThatHaveTheCertificate = new Dictionary<JobPositionDto, JobCertificateDto>();

                var activeCertDescIds = await _context.CertificateDescriptions.Where(x => x.Active == 1).Select(x => x.Id).ToListAsync();

                foreach (var pos in activePositions)
                {
                    var positionCerts = await _jobCompetencyService.GetJobCertificatesById(pos.JobTitleId);

                    foreach (var cert in positionCerts)
                    {
                        if (cert.Id == idToFind)
                        {
                            if (!activeCertDescIds.Contains(cert.CertificateDescId))
                            {
                                cert.DescFre = "";
                                cert.DescEng = "";
                            }
                            PositionsThatHaveTheCertificate.Add(pos, cert);
                            break;
                        }
                    }
                }
            }

            return Page();
        }

    }
}
