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
            var currentCompetencies = (from obj in _db.JobRolePositionCompetencyRatings.Where(e => e.JobPositionId == query.ObjectiveId && e.CompetencyTypeId == query.TypeId)
                                       join pos in _db.JobRolePositionCompetencyRatings.Where(e => e.JobPositionId == query.PositionId && e.CompetencyTypeId == query.TypeId)
                                       on obj.CompetencyId equals pos.CompetencyId into currentcompetencies
                                       from competency in currentcompetencies.DefaultIfEmpty()
                                       orderby obj.CompetencyTypeId
                                       select new SharedJobCompetencyRating()
                                       {
                                           CompetencyId = obj.CompetencyId,
                                           CompetencyDescEng = obj.Competency.DescEng,
                                           CompetencyDescFre = obj.Competency.DescFre,
                                           RatingValueCur = competency == null ? "N/A" : competency.CompetencyRatingLevel.Value.ToString(),
                                           RatingValueObj = obj.CompetencyRatingLevel.Value.ToString(),
                                           CompetencyNameEng = obj.Competency.NameEng,
                                           CompetencyNameFre = obj.Competency.NameFre,
                                           TypeNameEng = obj.CompetencyType.NameEng,
                                           TypeNameFre = obj.CompetencyType.NameFre,
                                           TypeId = obj.CompetencyType.Id,
                                           RatingNameCurEng = competency == null ? "Your current position does not have this competency." : competency.CompetencyRatingLevel.NameEng,
                                           RatingNameCurFre = competency == null ? "Votre poste actuel ne possède pas cette compétence." : competency.CompetencyRatingLevel.NameFre,
                                           RatingNameObjEng = obj.CompetencyRatingLevel.NameEng,
                                           RatingNameObjFre = obj.CompetencyRatingLevel.NameFre,
                                           RatingDescCurEng = competency == null ? string.Empty : competency.CompetencyRatingLevel.DescEng,
                                           RatingDescCurFre = competency == null ? string.Empty : competency.CompetencyRatingLevel.DescFre,
                                           RatingDescObjEng = obj.CompetencyRatingLevel.DescEng,
                                           RatingDescObjFre = obj.CompetencyRatingLevel.DescFre,
                                           CompetencyLevelReqDescCurEng = competency == null ? string.Empty : competency.CompetencyLevelRequirement.DescEng,
                                           CompetencyLevelReqDescCurFre = competency == null ? string.Empty : competency.CompetencyLevelRequirement.DescFre,
                                           CompetencyLevelReqDescObjEng = obj.CompetencyLevelRequirement.DescEng,
                                           CompetencyLevelReqDescObjFre = obj.CompetencyLevelRequirement.DescFre,
                                           Active = competency.Competency.Active != 0 && obj.Competency.Active != 0 ? 1 : 0
                                       }).Where(e => e.RatingValueCur != e.RatingValueObj);

           var objectiveCompetencies = (from pos in _db.JobRolePositionCompetencyRatings.Where(e => e.JobPositionId == query.PositionId && e.CompetencyTypeId == query.TypeId)
                    join obj in _db.JobRolePositionCompetencyRatings.Where(e => e.JobPositionId == query.ObjectiveId && e.CompetencyTypeId == query.TypeId && e.Competency.Active!=0)
                    on pos.CompetencyId equals obj.CompetencyId into objectivecompetencies
                    from competency in objectivecompetencies.DefaultIfEmpty()
                    orderby pos.CompetencyTypeId
                    select new SharedJobCompetencyRating()
                    {
                        CompetencyId = pos.CompetencyId,
                        CompetencyDescEng = pos.Competency.DescEng,
                        CompetencyDescFre = pos.Competency.DescFre,
                        RatingValueCur = pos.CompetencyRatingLevel.Value.ToString(),
                        RatingValueObj = competency == null ? "N/A" : competency.CompetencyRatingLevel.Value.ToString(),
                        CompetencyNameEng = pos.Competency.NameEng,
                        CompetencyNameFre = pos.Competency.NameFre,
                        TypeNameEng = pos.CompetencyType.NameEng,
                        TypeNameFre = pos.CompetencyType.NameFre,
                        TypeId = pos.CompetencyType.Id,
                        RatingNameCurEng = pos.CompetencyRatingLevel.NameEng,
                        RatingNameCurFre = pos.CompetencyRatingLevel.NameFre,
                        RatingNameObjEng = competency == null ? "Your objective position does not have this competency." : competency.CompetencyRatingLevel.NameEng,
                        RatingNameObjFre = competency == null ? "Votre poste objectif n'a pas cette compétence." : competency.CompetencyRatingLevel.NameFre,
                        RatingDescCurEng = pos.CompetencyRatingLevel.DescEng,
                        RatingDescCurFre = pos.CompetencyRatingLevel.DescFre,
                        RatingDescObjEng = competency == null ? string.Empty : competency.CompetencyRatingLevel.DescEng,
                        RatingDescObjFre = competency == null ? string.Empty : competency.CompetencyRatingLevel.DescFre,
                        CompetencyLevelReqDescCurEng = pos.CompetencyLevelRequirement.DescEng,
                        CompetencyLevelReqDescCurFre = pos.CompetencyLevelRequirement.DescFre,
                        CompetencyLevelReqDescObjEng = competency == null ? string.Empty : competency.CompetencyLevelRequirement.DescEng,
                        CompetencyLevelReqDescObjFre = competency == null ? string.Empty : competency.CompetencyLevelRequirement.DescFre,
                        Active = competency.Competency.Active != 0 && pos.Competency.Active != 0 ? 1 : 0
                    }).Where(e => e.RatingValueCur != e.RatingValueObj);

            return currentCompetencies.Union(objectiveCompetencies).ToListAsync(cancellationToken);       
        }
    }
}
