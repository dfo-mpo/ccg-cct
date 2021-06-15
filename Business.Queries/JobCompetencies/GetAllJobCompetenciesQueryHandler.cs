using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobCompetencies
{
    public class GetAllJobCompetenciesQueryHandler : IQueryHandler<List<JobCompetencyDto>>
    {
        private readonly CctDbContext _db;

        public GetAllJobCompetenciesQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobCompetencyDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.Competencies
                .Select(e => new JobCompetencyDto()
                {
                    Id = e.Id,
                    NameEng = e.NameEng,
                    NameFre = e.NameFre,
                    DescEng = e.DescEng,
                    DescFre = e.DescFre,
                    Active = e.Active
                })
                .ToListAsync(cancellationToken);

        }
    }
}
