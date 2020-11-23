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

namespace Business.Queries.JobGroups
{
    public class GetJobGroupByIdQuery : IQuery<JobGroupDto>
    {
        public int Id { get; set; }
    }

    public class GetJobGroupByIdQueryHandler : IQueryHandler<GetJobGroupByIdQuery, JobGroupDto>
    {
        private readonly CctDbContext _db;

        public GetJobGroupByIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<JobGroupDto> HandleAsync(GetJobGroupByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobGroups.Where(e => e.Id == query.Id)
                .Select(e => new JobGroupDto()
                {
                    Id = e.Id

                }).SingleOrDefaultAsync(cancellationToken);
        }
    }
}
