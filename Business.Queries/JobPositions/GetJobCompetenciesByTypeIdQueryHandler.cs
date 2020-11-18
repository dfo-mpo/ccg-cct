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
    
    public class GetJobCompetenciesByTypeIdQuery : IQuery<List<Competency>>
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
    }
    public class GetJobCompetenciesByTypeIdQueryHandler : IQueryHandler<GetJobCompetenciesByTypeIdQuery, List<Competency>>
    {
        private readonly CctDbContext _db;

        public GetJobCompetenciesByTypeIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<Competency>> HandleAsync(GetJobCompetenciesByTypeIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.CompetencyTypeGroups.Where(e => e.CompetencyTypeId == query.TypeId)
                .Select(e => e.Competency)
                .ToListAsync(cancellationToken);
                           
        }
    }
}

