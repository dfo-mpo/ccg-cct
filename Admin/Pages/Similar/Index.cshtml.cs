using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Admin.Data;
using Business.Dtos.JobPositions;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DataModel;

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

        public bool DisplayNumberOfJobsForEachMatchingPercentage { get; set; } = false;

        public Dictionary<int, string> NumberOfMatchingPositionsPerPecrentagePerPosition { get; set; }

        public async Task OnGetAsync(string? numMatching)
        {
            JobPositions = await _jobPositionService.GetAllJobPositions();
            JobPositions = JobPositions.Where(x => x.Active == 1).ToList();
            SimilarSearchIds = await _jobPositionService.GetAllSimilarSearchIds();
            NumberOfMatchingPositionsPerPecrentagePerPosition = new Dictionary<int, string>();

            if (numMatching != null)
            {
                if (numMatching.ToLower() == "true")
                {
                    DisplayNumberOfJobsForEachMatchingPercentage = true;
                }
            }

            if (DisplayNumberOfJobsForEachMatchingPercentage)
            {
                Dictionary<int, bool> activeJobIds = new Dictionary<int, bool>();
                bool boolVar;

                foreach (var position in JobPositions)
                {
                    activeJobIds.Add(position.JobTitleId, true);
                }

                foreach (var position in JobPositions)
                {
                    JobPosition = await _context.SearchSimilarJobs.FirstOrDefaultAsync(m => m.Position == position.JobTitleId);
                    try
                    {
                        int numHundredPositions = 0;
                        var hundredPositions = JobPosition.HundredPercent.Split("&PositionId=");
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
                        var ninetyPositions = JobPosition.NinetyPercent.Split("&PositionId=");
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
                        var eightyPositions = JobPosition.EightyPercent.Split("&PositionId=");
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
                        var seventyPositions = JobPosition.SeventyPercent.Split("&PositionId=");
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
                            "&" + numNinetyPositions + "&" + numEightyPositions + "&" + numSeventyPositions);
                    }
                    catch
                    {
                        NumberOfMatchingPositionsPerPecrentagePerPosition.Add(position.JobTitleId, "-&-&-&-");
                    }
                } // foreach
            } // if
        } // OnGetAsync()
    } // IndexModel class
} // namespace