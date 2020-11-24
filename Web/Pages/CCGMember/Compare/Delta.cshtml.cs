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
        public JobCompetencyRating[] curratings1 { get; set; }
        public JobCompetencyRating[] objratings1 { get; set; }
        public JobCompetencyRating[] curratings2 { get; set; }
        public JobCompetencyRating[] objratings2 { get; set; }
        public JobCompetencyRating[] curratings3 { get; set; }
        public JobCompetencyRating[] objratings3 { get; set; }
        public JobCompetencyRating[] curratings4 { get; set; }
        public JobCompetencyRating[] objratings4 { get; set; }
        [BindProperty]
        public List<JobCompetencyRating> matchingcomp1 { get; set; }
        [BindProperty]
        public List<SharedJobCompetencyRating> diffcomp1 { get; set; }
        [BindProperty]
        public List<JobCompetencyRating> matchingcomp2 { get; set; }
        [BindProperty]
        public List<SharedJobCompetencyRating> diffcomp2 { get; set; }
        [BindProperty]
        public List<JobCompetencyRating> matchingcomp3 { get; set; }
        [BindProperty]
        public List<SharedJobCompetencyRating> diffcomp3 { get; set; }
        [BindProperty]
        public List<JobCompetencyRating> matchingcomp4 { get; set; }
        [BindProperty]
        public List<SharedJobCompetencyRating> diffcomp4 { get; set; }
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
            curratings1 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(current, 1);
            objratings1 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(obj, 1);
            curratings2 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(current, 2);
            objratings2 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(obj, 2);
            curratings3 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(current, 3);
            objratings3 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(obj, 3);
            curratings4 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(current, 4);
            objratings4 = await _jobpositionService.GetJobCompetencyRatingsByTypeId(obj, 4);
            matchingcomp1 = new List<JobCompetencyRating>();
            diffcomp1 = new List<SharedJobCompetencyRating>();
            matchingcomp2 = new List<JobCompetencyRating>();
            diffcomp2 = new List<SharedJobCompetencyRating>();
            matchingcomp3 = new List<JobCompetencyRating>();
            diffcomp3 = new List<SharedJobCompetencyRating>();
            matchingcomp4 = new List<JobCompetencyRating>();
            diffcomp4 = new List<SharedJobCompetencyRating>();

            foreach (var cur in curratings1)
            {
                foreach (var ob in objratings1)
                {
                    if (cur.CompetencyId == ob.CompetencyId)
                    {
                        if (cur.RatingValue == ob.RatingValue)
                        {
                            matchingcomp1.Add(ob);
                        }
                        else if (cur.RatingValue < ob.RatingValue)
                        {
                            diffcomp1.Add(new SharedJobCompetencyRating()
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

            foreach (var cur in curratings2)
            {
                foreach (var ob in objratings2)
                {
                    if (cur.CompetencyId == ob.CompetencyId)
                    {
                        if (cur.RatingValue == ob.RatingValue)
                        {
                            matchingcomp2.Add(ob);
                        }
                        else if (cur.RatingValue < ob.RatingValue)
                        {
                            diffcomp2.Add(new SharedJobCompetencyRating()
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

            foreach (var cur in curratings3)
            {
                foreach (var ob in objratings3)
                {
                    if (cur.CompetencyId == ob.CompetencyId)
                    {
                        if (cur.RatingValue == ob.RatingValue)
                        {
                            matchingcomp3.Add(ob);
                        }
                        else if(cur.RatingValue<ob.RatingValue)
                        {
                            diffcomp3.Add(new SharedJobCompetencyRating()
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
          }
        }
    }

