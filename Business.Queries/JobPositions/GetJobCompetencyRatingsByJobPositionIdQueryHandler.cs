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
    public class GetJobCompetencyRatingsByJobPositionIdQuery : IQuery<List<JobCompetencyRatingDto>>
    {
        public int Id { get; set; }
    }
    public class GetJobCompetencyRatingsByJobPositionIdQueryHandler : IQueryHandler<GetJobCompetencyRatingsByJobPositionIdQuery, List<JobCompetencyRatingDto>>
    {
        private readonly CctDbContext _db;

        public GetJobCompetencyRatingsByJobPositionIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobCompetencyRatingDto>> HandleAsync(GetJobCompetencyRatingsByJobPositionIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobRolePositionCompetencyRatings.Where(e => e.JobPositionId == query.Id)
                .Include(e=>e.Competency)
                .Include(e=>e.CompetencyType)
                .Include(e=>e.CompetencyRatingLevel)
                .Select(e=>new JobCompetencyRatingDto()
                {
                    JobPositionId = e.JobPositionId,
                    TypeId = e.CompetencyTypeId,
                    TypeNameEng = e.CompetencyType.NameEng,
                    TypeNameFre = e.CompetencyType.NameFre,
                    CompetencyId = e.Competency.Id,
                    CompetencyNameEng = e.Competency.NameEng,
                    CompetencyNameFre = e.Competency.NameFre,
                    CompetencyDescEng = e.Competency.DescEng,
                    CompetencyDescFre = e.Competency.DescFre,
                    RatingValue = e.CompetencyRatingLevel.Value,
                    RatingNameEng = e.CompetencyRatingLevel.NameEng,
                    RatingNameFre = e.CompetencyRatingLevel.NameFre,
                    RatingDescEng = e.CompetencyRatingLevel.DescEng,
                    RatingDescFre = e.CompetencyRatingLevel.DescFre
                })
                .ToListAsync(cancellationToken);
        }
    }
}
