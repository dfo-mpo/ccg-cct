using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobPositions;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobCompetencies
{
    public class GetJobCompetencyByIdQuery : IQuery<JobCompetencyDto>
    {
        public int Id { get; set; }
    }
    public class GetJobCompetencyByIdQueryHandler : IQueryHandler<GetJobCompetencyByIdQuery, JobCompetencyDto>
    {
        private readonly CctDbContext _db;

        public GetJobCompetencyByIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task<JobCompetencyDto> HandleAsync(GetJobCompetencyByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            var comp = await _db.CompetencyTypeGroups.Where(e => e.CompetencyId == query.Id)
                .Include(e => e.Competency)
                .Select(e => new JobCompetencyDto()
                {
                    Id = e.Competency.Id,
                    NameEng = e.Competency.NameEng,
                    NameFre = e.Competency.NameFre,
                    TypeNameEng = e.CompetencyType.NameEng,
                    TypeNameFre = e.CompetencyType.NameFre,
                    DescEng = e.Competency.DescEng,
                    DescFre = e.Competency.DescFre,
                    Active = e.Competency.Active,
                    TypeId = e.CompetencyTypeId
                }).FirstOrDefaultAsync(cancellationToken);

            var ratingsGroups = await _db.CompetencyRatingGroups.Where(x => x.CompetencyId == query.Id)
                .OrderBy(x => x.CompetencyRatingLevelId).ToListAsync();

            if (ratingsGroups.Count == 5)
            {
                var levelDescs = await _db.CompetencyLevelRequirements
                    .Where(x => ratingsGroups.Select(x => x.CompetencyLevelRequirementId).ToList()
                    .Contains(x.Id)).OrderBy(x => x.Id).ToListAsync();

                comp.Level1DescEng = levelDescs.ElementAt(0).DescEng;
                comp.Level1DescFre = levelDescs.ElementAt(0).DescFre;

                comp.Level2DescEng = levelDescs.ElementAt(1).DescEng;
                comp.Level2DescFre = levelDescs.ElementAt(1).DescFre;

                comp.Level3DescEng = levelDescs.ElementAt(2).DescEng;
                comp.Level3DescFre = levelDescs.ElementAt(2).DescFre;

                comp.Level4DescEng = levelDescs.ElementAt(3).DescEng;
                comp.Level4DescFre = levelDescs.ElementAt(3).DescFre;

                comp.Level5DescEng = levelDescs.ElementAt(4).DescEng;
                comp.Level5DescFre = levelDescs.ElementAt(4).DescFre;
            }

            return comp;
        }
    }
}