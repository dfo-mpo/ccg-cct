using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using Business.Dtos.JobGroups;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobGroupTitles
{
    public class GetJobGroupTitleByIdQuery : IQuery<JobGroupTitleDto>
    {
      public int Id { get; set; }
    }

    public class GetJobGroupTitleByIdQueryHandler : IQueryHandler<GetJobGroupTitleByIdQuery, JobGroupTitleDto>
    {
        private readonly CctDbContext _db;

        public GetJobGroupTitleByIdQueryHandler(CctDbContext db)
        {
           _db = db;
        }

        public Task<JobGroupTitleDto> HandleAsync(GetJobGroupTitleByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobPositions.Where(e => e.Id == query.Id)
                      .Select(e => new JobGroupTitleDto()
                      {
                        Id = e.Id

                      }).SingleOrDefaultAsync(cancellationToken);
        }
    }
}

