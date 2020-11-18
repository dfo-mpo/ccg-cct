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
        private readonly JobCompetencyService _jobcompetencyService;
        [BindProperty(SupportsGet = true)]
        public int current { get; set; }

        [BindProperty(SupportsGet = true)]
        public int obj { get; set; }
        public JobPosition curposition { get; set; }
        public JobPosition objposition { get; set; }
        public JobCompetencyRating[] curratings { get; set; }
        public JobCompetencyRating[] objratings { get; set; }
        [BindProperty]
        public List<JobCompetencyRating> matchingcomp { get; set; }
        [BindProperty]
        public List<SharedJobCompetencyRating> diff { get; set; }
        public DeltaModel(ILogger<DeltaModel> logger, JobCompetencyService jobcompetencyService)
        {
            //_logger = logger;
            _jobcompetencyService = jobcompetencyService;
        }
        public async Task OnGetAsync(int current, int obj)
        {
            curposition = await _jobcompetencyService.GetJobPosition(current);
            objposition = await _jobcompetencyService.GetJobPosition(obj);
            curratings = await _jobcompetencyService.GetJobCompetencyRatings(current);
            objratings = await _jobcompetencyService.GetJobCompetencyRatings(obj);
            matchingcomp = new List<JobCompetencyRating>();
            diff = new List<SharedJobCompetencyRating>();
            foreach (var cur in curratings)
            {
                foreach (var ob in objratings)
                {
                    if (cur.CompetencyId == ob.CompetencyId) {
                    if( cur.RatingValue == ob.RatingValue)
                    {
                            matchingcomp.Add(ob);
                    }
                        else
                        {
                            diff.Add(new SharedJobCompetencyRating()
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