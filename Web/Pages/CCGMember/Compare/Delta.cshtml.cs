using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages.CCGMember.Compare
{
    public class DeltaModel : PageModel
    {
        private readonly JobPositionService _jobpositionService;
        [BindProperty(SupportsGet = true)]
        public int current { get; set; }

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
        public DeltaModel(ILogger<DeltaModel> logger, JobPositionService jobcompetencyService)
        {
            //_logger = logger;
            _jobpositionService = jobcompetencyService;
        }
        public async Task OnGetAsync(int current, int obj)
        {
            curcertificates = await _jobpositionService.GetJobCertificatesById(current);
            objcertificates = await _jobpositionService.GetJobCertificatesById(obj);
            curposition = await _jobpositionService.GetJobPosition(current);
            objposition = await _jobpositionService.GetJobPosition(obj);
            curratings = await _jobpositionService.GetJobCompetencyRatings(current);
            objratings = await _jobpositionService.GetJobCompetencyRatings(obj);
            matchingcomp = new List<JobCompetencyRating>();
            diffcomp = new List<SharedJobCompetencyRating>();
            matchcert = new List<JobCertificate>();
            diffcert = new List<JobCertificate>();

            foreach (var ob in objcertificates)
            {
                if (!Array.Exists(curcertificates, c => c.Id == ob.Id))
                {
                    diffcert.Add(new JobCertificate()
                    {
                        Id = ob.Id,
                        DescEng = ob.DescEng,
                        DescFre = ob.DescFre,
                        NameEng = ob.NameEng,
                        NameFre = ob.NameFre,
                        RequireIndicatorEng = ob.RequireIndicatorEng,
                        RequireIndicatorFre = ob.RequireIndicatorFre
                    });
                }
                foreach (var cer in curcertificates)
                {
                    if (cer.Id == ob.Id)
                    {
                        matchcert.Add(new JobCertificate()
                        {
                            Id = cer.Id,
                            DescEng = cer.DescEng,
                            DescFre = cer.DescFre,
                            NameFre = cer.NameFre,
                            NameEng = cer.NameEng,
                            RequireIndicatorFre = cer.RequireIndicatorFre,
                            RequireIndicatorEng = cer.RequireIndicatorEng
                        })
                       ;
                    }
                }
            }

            foreach (var cur in curratings)
                {
                    foreach (var ob in objratings)
                    {
                        if (cur.CompetencyId == ob.CompetencyId)
                        {
                            if (cur.RatingValue == ob.RatingValue)
                            {
                                matchingcomp.Add(ob);
                            }
                            else
                            {
                                diffcomp.Add(new SharedJobCompetencyRating()
                                {
                                    TypeId = ob.TypeId,
                                    CompetencyDescEng = ob.CompetencyDescEng,
                                    CompetencyDescFre = ob.CompetencyDescFre,
                                    CompetencyNameEng = ob.CompetencyNameEng,
                                    CompetencyNameFre = ob.CompetencyNameFre,
                                    RatingValueCur = cur.RatingValue,
                                    RatingValueObj = ob.RatingValue,
                                    TypeNameEng = ob.TypeNameEng,
                                    TypeNameFre = ob.TypeNameFre
                                })
                               ;
                            }
                        }

                    }
                }
            }

        }
    }

