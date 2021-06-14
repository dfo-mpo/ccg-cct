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

        public Task<JobCompetencyDto> HandleAsync(GetJobCompetencyByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.CompetencyTypeGroups.Where(e => e.CompetencyId == query.Id)
                .Include(e => e.Competency)
                .Select(e => new JobCompetencyDto()
                {
                    Id = e.Competency.Id,
                    NameEng = e.Competency.NameEng,
                    NameFre = e.Competency.NameFre,
                    DescEng = e.Competency.DescEng,
                    DescFre = e.Competency.DescFre,
                    Active = e.Competency.Active

                }).FirstOrDefaultAsync(cancellationToken);
        }
    }
}