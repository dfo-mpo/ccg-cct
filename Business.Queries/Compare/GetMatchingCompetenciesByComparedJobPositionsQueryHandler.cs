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
                    where obj.CompetencyRatingLevel.Value == pos.CompetencyRatingLevel.Value
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
                        RatingNameCurEng = pos.CompetencyRatingLevel.NameEng,
                        RatingNameCurFre = pos.CompetencyRatingLevel.NameFre,
                        RatingNameObjEng = obj == null ? "Your objective position does not have this competency." : obj.CompetencyRatingLevel.NameEng,
                        RatingNameObjFre = obj == null ? "Votre poste objectif n'a pas cette compétence." : obj.CompetencyRatingLevel.NameFre,
                        RatingDescCurEng = pos.CompetencyRatingLevel.DescEng,
                        RatingDescCurFre = pos.CompetencyRatingLevel.DescFre,
                        RatingDescObjEng = obj == null ? string.Empty : obj.CompetencyRatingLevel.DescEng,
                        RatingDescObjFre = obj == null ? string.Empty : obj.CompetencyRatingLevel.DescFre,
                        CompetencyLevelReqDescCurEng = pos.CompetencyLevelRequirement.DescEng,
                        CompetencyLevelReqDescCurFre = pos.CompetencyLevelRequirement.DescFre,
                        CompetencyLevelReqDescObjEng = obj == null ? string.Empty : obj.CompetencyLevelRequirement.DescEng,
                        CompetencyLevelReqDescObjFre = obj == null ? string.Empty : obj.CompetencyLevelRequirement.DescFre,
                        Active = 1

                    }).ToListAsync(cancellationToken);
        }

    }
}
