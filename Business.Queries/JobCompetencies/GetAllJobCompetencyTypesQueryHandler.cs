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
    public class GetAllJobCompetencyTypesQueryHandler : IQueryHandler<List<JobCompetencyTypeDto>>
    {
        private readonly CctDbContext _db;

        public GetAllJobCompetencyTypesQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobCompetencyTypeDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.CompetencyTypes
                .Select(e => new JobCompetencyTypeDto()
                {
                    Id = e.Id,
                    NameEng = e.NameEng,
                    NameFre = e.NameFre
                })
                .ToListAsync(cancellationToken);

        }
    }
}