using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobPositions;
using System;

namespace Business.Queries.JobPositions
{
    public class GetAllSimilarPositionsByPositionIdQuery : IQuery<List<JobPositionDto>>
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int[] SameLevels { get; set; } 
        public int[] HigherLevels { get; set; }

        public bool SameCondition(int JobCompetencyId, int LevelValue, List<JobCompetencyRatingDto> CurrentCompetencyRatings, int[] SameLevelCompetencies)
        {
            bool res = true;
            if (SameLevelCompetencies.Contains(JobCompetencyId)) { 
            foreach (var c in CurrentCompetencyRatings)
            {
                if (JobCompetencyId == c.CompetencyId && LevelValue!=c.RatingValue)
                {
                    res = false;           
                }
            }
            }
            return res;
        }
        public bool HigherCondition(int JobCompetencyId, int LevelValue, List<JobCompetencyRatingDto> CurrentCompetencyRatings, int[] HigherLevelCompetencies)
        {
            bool res = true;
            if (HigherLevelCompetencies.Contains(JobCompetencyId)) { 
            foreach (var c in CurrentCompetencyRatings)
            {
                if (JobCompetencyId == c.CompetencyId && LevelValue <= c.RatingValue)
                {
                    res = false;
                }
            }
            }
            return res;
        }
    }

    public class GetAllSimilarPositionsByPositionIdQueryHandler : IQueryHandler<GetAllSimilarPositionsByPositionIdQuery, List<JobPositionDto>>
    {
        private readonly CctDbContext _db;

        public GetAllSimilarPositionsByPositionIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobPositionDto>> HandleAsync(GetAllSimilarPositionsByPositionIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            var currentcompetencies = _db.JobRolePositionCompetencyRatings.Where(e => e.JobPositionId == query.Id && e.CompetencyTypeId == query.TypeId)
          .Include(e => e.Competency)
          .Select(e => new JobCompetencyRatingDto()
          {
              JobPositionId=e.JobPositionId,
              CompetencyId=e.CompetencyId,
              RatingValue=e.CompetencyRatingLevel.Value
          })
            .ToList();
            return (from e in _db.JobRolePositionCompetencyRatings
                    .Where(e => e.CompetencyTypeId == query.TypeId)
                    .Where(e => currentcompetencies.Select(y => y.CompetencyId).Contains(e.CompetencyId))
                    select
                    query.HigherCondition(e.CompetencyId, e.CompetencyRatingLevel.Value, currentcompetencies, query.HigherLevels) && query.SameCondition(e.CompetencyId, e.CompetencyRatingLevel.Value, currentcompetencies, query.SameLevels) ?
                    new JobPositionDto()
                    {
                        JobGroupId = e.JobGroupId,
                        JobLevelId = e.JobGroupLevelId,
                        JobLevelValue = e.JobGroupLevel.LevelValue,
                        JobGroupCode = e.JobGroup.Code,
                        JobGroupTitleEng = e.JobGroup.NameEng,
                        JobGroupTitleFre = e.JobGroup.NameFre,
                        JobGroupLevelId = e.JobGroupLevelId,
                        JobGroupLevelValue = e.JobGroupLevel.LevelValue,
                        JobTitleId = e.JobPositionId,
                        JobTitleFre = e.JobPosition.TitleFre,
                        JobTitleEng = e.JobPosition.TitleEng,
                        JobCompetencyId = e.CompetencyId,
                        JobCompetencyRatingValue = e.CompetencyRatingLevel.Value,
                        JobCompetencyTypeId = e.CompetencyTypeId
                    }:null
                    ).ToListAsync(cancellationToken);

        }
    }
}
