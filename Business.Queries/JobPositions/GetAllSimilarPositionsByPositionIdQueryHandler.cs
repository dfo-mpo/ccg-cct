using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobPositions;

namespace Business.Queries.JobPositions
{
    public class GetAllSimilarPositionsByPositionIdQuery : IQuery<List<JobPositionDto>>
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int[] SameLevels { get; set; } //needs implementation
        public int[] HigherLevels { get; set; }
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
                .Select(e => new
                {
                    e.CompetencyId,
                    e.CompetencyRatingLevel
                }
        ).ToList();
            return _db.JobRolePositionCompetencyRatings
                .Where(e => e.JobPositionId == query.Id
            && e.CompetencyTypeId == query.TypeId)
                .Where(e => currentcompetencies.Select(e=>e.CompetencyId).Contains(e.CompetencyId))
                //implement rating comparison
                //.Where(e => query.SameLevels.Contains(e.CompetencyId) ? e.CompetencyRatingLevel.Value == currentcompetencies.Where(c => c.CompetencyId==e.CompetencyId):false)
                .Include(e => e.Competency)
                .Select(e => new JobPositionDto()
                {
                    JobGroupId = e.JobGroupId,
                    JobLevelId = e.JobGroupLevel.Id,
                    JobLevelValue = e.JobGroupLevel.LevelValue,
                    JobGroupCode = e.JobGroup.Code,
                    JobGroupTitleEng = e.JobGroup.NameEng,
                    JobGroupTitleFre = e.JobGroup.NameFre,
                    JobGroupLevelId = e.JobGroupLevelId,
                    JobGroupLevelValue = e.JobGroupLevel.LevelValue,
                    JobTitleId = e.JobPositionId,
                    JobTitleFre = e.JobPosition.TitleFre,
                    JobTitleEng = e.JobPosition.TitleEng
                })
                    .ToListAsync(cancellationToken);
        }
    }
}
