using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;
using Business.Dtos.Shared;

namespace Business.Queries.Compare
{
    public class GetMatchingCompetenciesByComparedJobPositionsQuery : IQuery<List<SharedJobCompetencyRating>>
    {
        public int PositionId { get; set; }
        public int ObjectiveId { get; set; }
        public int TypeId { get; set; }
    }
    public class GetMatchingCompetenciesByComparedJobPositionsQueryHandler : IQueryHandler<GetMatchingCompetenciesByComparedJobPositionsQuery, List<SharedJobCompetencyRating>>
    {
        private readonly CctDbContext _db;

        public GetMatchingCompetenciesByComparedJobPositionsQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<SharedJobCompetencyRating>> HandleAsync(GetMatchingCompetenciesByComparedJobPositionsQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return (from pos in _db.JobRolePositionCompetencyRatings.Where(e => e.JobPositionId == query.PositionId && e.CompetencyTypeId == query.TypeId && e.Competency.Active != 0)
                    join obj in _db.JobRolePositionCompetencyRatings.Where(e => e.JobPositionId == query.ObjectiveId && e.CompetencyTypeId == query.TypeId && e.Competency.Active != 0)
                    on pos.CompetencyId equals obj.CompetencyId                 
                    orderby obj.CompetencyTypeId
                    select new SharedJobCompetencyRating()
                    {
                        CompetencyId = pos.CompetencyId,
                        CompetencyDescEng = pos.Competency.DescEng,
                        CompetencyDescFre = pos.Competency.DescFre,
                        RatingValueCur = pos.CompetencyRatingLevel.Value.ToString(),
                        RatingValueObj = obj.CompetencyRatingLevel.Value.ToString(),
                        CompetencyNameEng = pos.Competency.NameEng,
                        CompetencyNameFre = pos.Competency.NameFre,
                        TypeNameEng = pos.CompetencyType.NameEng,
                        TypeNameFre = pos.CompetencyType.NameFre,
                        TypeId = pos.CompetencyType.Id,
                        Active = 1

                    }).ToListAsync(cancellationToken);
        }

    }
}
