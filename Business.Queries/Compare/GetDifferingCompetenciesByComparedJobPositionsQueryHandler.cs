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

    public class GetDifferingCompetenciesByComparedJobPositionsQuery : IQuery<List<SharedJobCompetencyRating>>
    {
        public int PositionId { get; set; }
        public int ObjectiveId { get; set; }
        public int TypeId { get; set; }
    }

    public class GetDifferingCompetenciesByComparedJobPositionsQueryHandler : IQueryHandler<GetDifferingCompetenciesByComparedJobPositionsQuery, List<SharedJobCompetencyRating>>
    {
        private readonly CctDbContext _db;

        public GetDifferingCompetenciesByComparedJobPositionsQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<SharedJobCompetencyRating>> HandleAsync(GetDifferingCompetenciesByComparedJobPositionsQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return (from obj in _db.JobRolePositionCompetencyRatings.Where(e => e.JobPositionId == query.ObjectiveId && e.CompetencyTypeId == query.TypeId)
                    join pos in _db.JobRolePositionCompetencyRatings.Where(e => e.JobPositionId == query.PositionId && e.CompetencyTypeId == query.TypeId)
                    on obj.CompetencyId equals pos.CompetencyId into currentpositions
                    from current in currentpositions.DefaultIfEmpty()
                    orderby obj.CompetencyTypeId
                    select new SharedJobCompetencyRating()
                    {
                        CompetencyId = obj.CompetencyId,
                        CompetencyDescEng = obj.Competency.DescEng,
                        CompetencyDescFre = obj.Competency.DescFre,
                        RatingValueCur = current == null ? "N/A" : current.CompetencyRatingLevel.Value.ToString(),    
                        RatingValueObj = obj.CompetencyRatingLevel.Value.ToString(),
                        CompetencyNameEng = obj.Competency.NameEng,
                        CompetencyNameFre = obj.Competency.NameFre,
                        TypeNameEng = obj.CompetencyType.NameEng,
                        TypeNameFre = obj.CompetencyType.NameFre,
                        TypeId = obj.CompetencyType.Id,
                        RatingDescCurEng = current == null ? "N/A" : current.CompetencyRatingLevel.DescEng,
                        RatingDescCurFre = current == null ? "N/A" : current.CompetencyRatingLevel.DescFre,
                        RatingDescObjEng = obj.CompetencyLevelRequirement.DescEng,
                        RatingDescObjFre = obj.CompetencyRatingLevel.DescFre
                    
                    }).Where(e => e.RatingValueCur != e.RatingValueObj).ToListAsync(cancellationToken);
        }
    }
}
