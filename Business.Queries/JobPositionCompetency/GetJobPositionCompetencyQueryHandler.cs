using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using DataModel;
using System.Threading.Tasks;
using CCG.AspNetCore;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobPositionCompetency
{
    public class JobPositionCompetencyDto
    {
        public int ClassificationId { get; set; }
        public string ClassificationName { get; set; }
        public int ClassificationLevelId { get; set; }
        public string ClassificationLevel { get; set; }
        public int JobPositionId { get; set; }
        public string JobPositionNameEng { get; set; }
        public string JobPositionNameFre { get; set; }
        public int jobRegionId { get; set; }
        public string JobRegionNameFre { get; set; }
        public string JobRegionNameEng { get; set; }
        public int JobTaskId { get; set; }
        public string JobTaskDescEng { get; set; }
        public string JobTaskDescFra { get; set; }

        public Competency Competencies { get; set; }
        public CompetencyType CompetencyTypes { get; set; }
        public CompetencyRatingLevel CompetencyRatingLevels { get; set; }
        public CompetencyLevelRequirement CompetencyLevelRequirements { get; set; }
    }
  
    public class GetJobPositionCompetencyQueryHandler : IQueryHandler<List<JobPositionCompetencyDto>>
    {
        private readonly CctDbContext _db;

        public GetJobPositionCompetencyQueryHandler(CctDbContext db)
        {
            _db = db;
        }
        public Task<List<JobPositionCompetencyDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobGroupPositions
                  .Select(e => new JobPositionCompetencyDto()
                  {
                      //

                  }).ToListAsync(cancellationToken);
        }

    }
}
