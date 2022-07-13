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
    public class LocateModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        private readonly JobPositionService _jobPositionService;

        public LocateModel(DataModel.CctDbContext context, JobPositionService jobPositionService)
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

        public bool LocatingAPosition { get; set; } = false;

        public JobPositionDto PositionBengLocated { get; set; }

        public List<JobPositionDto> PositionsThatHaveItAtHundredMatch { get; set; }

        public List<JobPositionDto> PositionsThatHaveItAtNinetyMatch { get; set; }
        
        public List<JobPositionDto> PositionsThatHaveItAtEightyMatch { get; set; }

        public List<JobPositionDto> PositionsThatHaveItAtSeventyMatch { get; set; }

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

            JobPositions = (await _jobPositionService.GetAllJobPositions()).Where(x => x.Active == 1).ToList();
            SimilarSearchIds = await _jobPositionService.GetAllSimilarSearchIds();

            if (id != null)
            {
                try
                {
                    PositionBengLocated = await _jobPositionService.GetJobPositionById(id.Value);
                }
                catch
                {
                    PositionBengLocated = null;
                }

                if (PositionBengLocated != null)
                {
                    if (PositionBengLocated.Active == 1)
                    {
                        LocatingAPosition = true;
                    }
                }
            }

            if (LocatingAPosition)
            {
                var activeJobIds = JobPositions.Select(x => x.JobTitleId).ToList();
                SimilarSearchIds = SimilarSearchIds.Where(x => activeJobIds.Contains(x)).ToArray();
                int idToLookFor = id.Value;
                var positionsToLookThrough = await _context.SearchSimilarJobs.Where(x => SimilarSearchIds.Contains(x.Position)).ToListAsync();

                PositionsThatHaveItAtHundredMatch = new List<JobPositionDto>();
                PositionsThatHaveItAtNinetyMatch = new List<JobPositionDto>();
                PositionsThatHaveItAtEightyMatch = new List<JobPositionDto>();
                PositionsThatHaveItAtSeventyMatch = new List<JobPositionDto>();

                foreach (var pos in positionsToLookThrough)
                {
                    var hundredIds = pos.HundredPercent.Split("&PositionId=").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
                    var ninetyIds = pos.NinetyPercent.Split("&PositionId=").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
                    var eightyIds = pos.EightyPercent.Split("&PositionId=").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
                    var seventyIds = pos.SeventyPercent.Split("&PositionId=").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

                    bool addedThisJob = false;

                    foreach (var jobId in hundredIds)
                    {
                        try
                        {
                            int intId = int.Parse(jobId);
                            if (intId == idToLookFor)
                            {
                                PositionsThatHaveItAtHundredMatch.Add(JobPositions.Where(x => x.JobTitleId == pos.Position).FirstOrDefault());
                                addedThisJob = true;
                                break;
                            }
                        }
                        catch { }
                    }

                    if (!addedThisJob)
                    {
                        foreach (var jobId in ninetyIds)
                        {
                            try
                            {
                                int intId = int.Parse(jobId);
                                if (intId == idToLookFor)
                                {
                                    PositionsThatHaveItAtNinetyMatch.Add(JobPositions.Where(x => x.JobTitleId == pos.Position).FirstOrDefault());
                                    addedThisJob = true;
                                    break;
                                }
                            }
                            catch { }
                        }
                    }

                    if (!addedThisJob)
                    {
                        foreach (var jobId in eightyIds)
                        {
                            try
                            {
                                int intId = int.Parse(jobId);
                                if (intId == idToLookFor)
                                {
                                    PositionsThatHaveItAtEightyMatch.Add(JobPositions.Where(x => x.JobTitleId == pos.Position).FirstOrDefault());
                                    addedThisJob = true;
                                    break;
                                }
                            }
                            catch { }
                        }
                    }

                    if (!addedThisJob)
                    {
                        foreach (var jobId in seventyIds)
                        {
                            try
                            {
                                int intId = int.Parse(jobId);
                                if (intId == idToLookFor)
                                {
                                    PositionsThatHaveItAtSeventyMatch.Add(JobPositions.Where(x => x.JobTitleId == pos.Position).FirstOrDefault());
                                    addedThisJob = true;
                                    break;
                                }
                            }
                            catch { }
                        }
                    }

                }
            }

            return Page();
        }

    }
}
