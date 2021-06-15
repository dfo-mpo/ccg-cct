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
    public class GetAllJobCompetenciesByTypeIdQuery : IQuery<List<JobCompetencyDto>>
    {
        public int TypeId { get; set; }
    }
    public class GetAllJobCompetenciesByTypeIdQueryHandler : IQueryHandler<GetAllJobCompetenciesByTypeIdQuery, List<JobCompetencyDto>>
    {
        private readonly CctDbContext _db;

        public GetAllJobCompetenciesByTypeIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobCompetencyDto>> HandleAsync(GetAllJobCompetenciesByTypeIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.CompetencyTypeGroups.Where(e=>e.CompetencyTypeId==query.TypeId)
                .Include(e=>e.Competency)
                .Select(e => new JobCompetencyDto()
                {
                    Id = e.Competency.Id,
                    NameEng = e.Competency.NameEng,
                    NameFre = e.Competency.NameFre,
                    DescEng = e.Competency.DescEng,
                    DescFre = e.Competency.DescFre,
                    Active = e.Competency.Active
                })
                .ToListAsync(cancellationToken);

        }
    }
}
