using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobCompetencies
{
    public class GetJobCompetencyTypeByIdQuery : IQuery<JobCompetencyTypeDto>
    {
        public int TypeId { get; set; }
    }
    public class GetJobCompetencyTypeByIdQueryHandler : IQueryHandler<GetJobCompetencyTypeByIdQuery, JobCompetencyTypeDto>
    {
        private readonly CctDbContext _db;

        public GetJobCompetencyTypeByIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<JobCompetencyTypeDto> HandleAsync(GetJobCompetencyTypeByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.CompetencyTypes.Where(e => e.Id == query.TypeId)
                .Select(e => new JobCompetencyTypeDto()
                {
                    Id = e.Id,
                    NameEng = e.NameEng,
                    NameFre = e.NameFre,
                }).FirstOrDefaultAsync(cancellationToken);
        }
    }
}
