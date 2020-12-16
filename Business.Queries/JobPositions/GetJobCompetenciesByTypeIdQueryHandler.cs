using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobPositions
{  
    public class GetJobCompetenciesByTypeIdQuery : IQuery<List<JobCompetencyRatingDto>>
    {
        public int Id { get; set; }
        public int competencytypeId { get; set; }
    }
    public class GetJobCompetenciesByTypeIdQueryHandler : IQueryHandler<GetJobCompetenciesByTypeIdQuery, List<JobCompetencyRatingDto>>
    {
        private readonly CctDbContext _db;

        public GetJobCompetenciesByTypeIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobCompetencyRatingDto>> HandleAsync(GetJobCompetenciesByTypeIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobRolePositionCompetencyRatings.Where(e => e.JobPositionId == query.Id && e.CompetencyTypeId == query.competencytypeId)
                .Include(e => e.Competency)
                .Select(e => new JobCompetencyRatingDto()
                {
                    TypeId = e.CompetencyTypeId,
                    TypeNameEng = e.CompetencyType.NameEng,
                    TypeNameFre = e.CompetencyType.NameFre,
                    RatingDescFre = e.CompetencyRatingLevel.DescFre,
                    RatingDescEng = e.CompetencyRatingLevel.DescEng,
                    CompetencyId = e.CompetencyId,
                    JobPositionId = e.JobPositionId,
                    CompetencyDescEng = e.Competency.DescEng,
                    CompetencyDescFre = e.Competency.DescFre,
                    CompetencyNameEng = e.Competency.NameEng,
                    CompetencyNameFre = e.Competency.NameFre,
                    RatingNameEng = e.CompetencyRatingLevel.NameEng,
                    RatingNameFre = e.CompetencyRatingLevel.NameFre,
                    RatingValue = e.CompetencyRatingLevel.Value,
                    CompetencyLevelReqDescEng = e.CompetencyLevelRequirement.DescEng,
                    CompetencyLevelReqDescFre = e.CompetencyLevelRequirement.DescFre
                })
                .ToListAsync(cancellationToken);
                           
        }
    }
}

