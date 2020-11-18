using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Business.Queries.Dtos;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobPositions
{
    
    public class GetJobCompetenciesByTypeIdQuery : IQuery<List<JobCompetencyDto>>
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
    }
    public class GetJobCompetenciesByTypeIdQueryHandler : IQueryHandler<GetJobCompetenciesByTypeIdQuery, List<JobCompetencyDto>>
    {
        private readonly CctDbContext _db;

        public GetJobCompetenciesByTypeIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobCompetencyDto>> HandleAsync(GetJobCompetenciesByTypeIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.CompetencyTypeGroups.Where(e => e.CompetencyTypeId == query.TypeId)
                .Include(e => e.Competency)
                .Select(e => new JobCompetencyDto()
                {
                    Type = e.CompetencyType.NameEng,
                    Id = e.CompetencyId,
                    DescEng = e.Competency.DescEng,
                    DescFre = e.Competency.DescFre,
                    NameEng = e.Competency.NameEng,
                    NameFre = e.Competency.NameFre
                })
                .ToListAsync(cancellationToken);
                           
        }
    }
}

