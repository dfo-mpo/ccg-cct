using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobCompetencies
{
    public class GetJobCompetencyLevelRequirementByIdLevelIdQuery : IQuery<JobCompetencyRatingDto>
    {
        public int Id { get; set; }
        public int LevelId { get; set; }
    }
    public class GetJobCompetencyLevelRequirementByIdLevelIdQueryHandler : IQueryHandler<GetJobCompetencyLevelRequirementByIdLevelIdQuery, JobCompetencyRatingDto>
    {
        private readonly CctDbContext _db;

        public GetJobCompetencyLevelRequirementByIdLevelIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<JobCompetencyRatingDto> HandleAsync(GetJobCompetencyLevelRequirementByIdLevelIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.CompetencyRatingGroups.Where(e => e.CompetencyId == query.Id && e.CompetencyRatingLevelId == query.LevelId)
                .Include(e => e.Competency)
                .Select(e => new JobCompetencyRatingDto()
                {
                    CompetencyNameEng = e.Competency.NameEng,
                    CompetencyNameFre = e.Competency.NameFre,
                    CompetencyDescEng = e.Competency.DescEng,
                    CompetencyDescFre = e.Competency.DescFre,
                    CompetencyLevelReqDescEng = e.CompetencyLevelRequirement.DescEng,
                    CompetencyLevelReqDescFre = e.CompetencyLevelRequirement.DescFre,
                    CompetencyRatingLevelId = e.CompetencyRatingLevelId,
                    CompetencyLevelRequirementId = e.CompetencyLevelRequirementId,
                    RatingNameEng = e.CompetencyRatingLevel.NameEng,
                    RatingNameFre = e.CompetencyRatingLevel.NameFre,
                    RatingDescEng = e.CompetencyRatingLevel.DescEng,
                    RatingDescFre = e.CompetencyRatingLevel.DescFre,
                    RatingValue = e.CompetencyRatingLevel.Value,
                    CompetencyId = e.CompetencyId,
                    Active = e.Competency.Active

                }).FirstOrDefaultAsync(cancellationToken);
        }
    }
}