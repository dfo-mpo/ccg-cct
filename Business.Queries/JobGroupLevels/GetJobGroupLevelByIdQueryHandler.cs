using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobGroups;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;


namespace Business.Queries.JobGroupLevels
{
    public class GetJobGroupLevelByIdQuery : IQuery<JobGroupLevelDto>
    {
        public int Id { get; set; }
    }

    public class GetJobGroupLevelByIdQueryHandler : IQueryHandler<GetJobGroupLevelByIdQuery, JobGroupLevelDto>
    {
        private readonly CctDbContext _db;

        public GetJobGroupLevelByIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<JobGroupLevelDto> HandleAsync(GetJobGroupLevelByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobGroupLevels.Where(e => e.Id == query.Id)
                      .Select(e => new JobGroupLevelDto()
                      {
                        Id = e.Id,
                        Active = e.Active

                      }).SingleOrDefaultAsync(cancellationToken);
        }
    }
}
