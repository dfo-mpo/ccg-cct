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

namespace Admin.Pages.Similar
{
    public class IndexModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        private readonly JobPositionService _jobPositionService;

        public IndexModel(DataModel.CctDbContext context, JobPositionService jobPositionService)
        {
            _context = context;
            _jobPositionService = jobPositionService;
        }
        [BindProperty(SupportsGet = true)]
        public string Filter { get; set; }
        public IList<JobPositionDto> JobPositions { get; set; }
        public int[] SimilarSearchIds { get; set; }

        [BindProperty]
        public SearchSimilarJob JobPosition { get; set; }

        public bool DisplayTopOfPage { get; set; }

        public bool DisplayNumberOfJobsForEachMatchingPercentage { get; set; } = false;

        public Dictionary<int, string> NumberOfMatchingPositionsPerPecrentagePerPosition { get; set; }

        public async Task OnGetAsync(string? numMatching)
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

            string? dislpayNumMatchingStr = HttpContext.Session.GetString("DisplayNumberOfJobsForEachMatchingPercentage");
            if (!string.IsNullOrEmpty(dislpayNumMatchingStr))
            {
                if (dislpayNumMatchingStr.ToLower() == "true")
                {
                    DisplayNumberOfJobsForEachMatchingPercentage = true;
                }
                else
                {
                    DisplayNumberOfJobsForEachMatchingPercentage = false;
                }
            }
            if (numMatching != null)
            {
                if (numMatching.ToLower() == "true")
                {
                    DisplayNumberOfJobsForEachMatchingPercentage = true;
                    HttpContext.Session.SetString("DisplayNumberOfJobsForEachMatchingPercentage", "true");
                }
                else if (numMatching.ToLower() == "false")
                {
                    DisplayNumberOfJobsForEachMatchingPercentage = false;
                    HttpContext.Session.SetString("DisplayNumberOfJobsForEachMatchingPercentage", "false");
                }
            }

            JobPositions = await _jobPositionService.GetAllJobPositions();
            JobPositions = JobPositions.Where(x => x.Active == 1).ToList();

            var jobsToLoop = JobPositions;

            if (!string.IsNullOrWhiteSpace(Filter))
            {
                string filter = Filter.ToLower();
                jobsToLoop = JobPositions.Where(e => 
                    ((e.JobTitleEng.ToLower().Contains(filter)
                    || e.JobTitleFre.ToLower().Contains(filter)
                    || e.LevelCode.ToLower().Contains(filter))
                    && (e.Active == 1))
                    ).ToList();
            }

            SimilarSearchIds = await _jobPositionService.GetAllSimilarSearchIds();
            NumberOfMatchingPositionsPerPecrentagePerPosition = new Dictionary<int, string>();

            if (DisplayNumberOfJobsForEachMatchingPercentage)
            {
                Dictionary<int, bool> activeJobIds = new Dictionary<int, bool>();
                bool boolVar;

                foreach (var position in JobPositions)
                {
                    activeJobIds.Add(position.JobTitleId, true);
                }

                foreach (var position in jobsToLoop)
                {
                    JobPosition = await _context.SearchSimilarJobs.FirstOrDefaultAsync(m => m.Position == position.JobTitleId);
                    if (JobPosition != null)
                    {
                        try
                        {
                            int numHundredPositions = 0;
                            var hundredPositions = JobPosition.HundredPercent.Split("&PositionId=").Distinct().ToList();
                            foreach (var pos in hundredPositions)
                            {
                                if (!string.IsNullOrWhiteSpace(pos))
                                {
                                    if (activeJobIds.TryGetValue(int.Parse(pos), out boolVar))
                                    {
                                        numHundredPositions++;
                                    }
                                }
                            }

                            int numNinetyPositions = 0;
                            var ninetyPositions = JobPosition.NinetyPercent.Split("&PositionId=").Distinct().ToList();
                            foreach (var pos in ninetyPositions)
                            {
                                if (!string.IsNullOrWhiteSpace(pos))
                                {
                                    if (activeJobIds.TryGetValue(int.Parse(pos), out boolVar))
                                    {
                                        numNinetyPositions++;
                                    }
                                }
                            }

                            int numEightyPositions = 0;
                            var eightyPositions = JobPosition.EightyPercent.Split("&PositionId=").Distinct().ToList();
                            foreach (var pos in eightyPositions)
                            {
                                if (!string.IsNullOrWhiteSpace(pos))
                                {
                                    if (activeJobIds.TryGetValue(int.Parse(pos), out boolVar))
                                    {
                                        numEightyPositions++;
                                    }
                                }
                            }

                            int numSeventyPositions = 0;
                            var seventyPositions = JobPosition.SeventyPercent.Split("&PositionId=").Distinct().ToList();
                            foreach (var pos in seventyPositions)
                            {
                                if (!string.IsNullOrWhiteSpace(pos))
                                {
                                    if (activeJobIds.TryGetValue(int.Parse(pos), out boolVar))
                                    {
                                        numSeventyPositions++;
                                    }
                                }
                            }

                            NumberOfMatchingPositionsPerPecrentagePerPosition.Add(position.JobTitleId, numHundredPositions.ToString() +
                                "&" + numNinetyPositions.ToString() + "&" + numEightyPositions.ToString() + "&"
                                + numSeventyPositions.ToString());
                        }
                        catch
                        {
                            NumberOfMatchingPositionsPerPecrentagePerPosition.Add(position.JobTitleId, "-&-&-&-");
                        }
                    }
                    else
                    {
                        NumberOfMatchingPositionsPerPecrentagePerPosition.Add(position.JobTitleId, "0&0&0&0");
                    }
                }
            }
        }

    }
}