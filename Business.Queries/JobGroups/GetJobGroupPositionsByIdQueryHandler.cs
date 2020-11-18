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
    public class GetJobGroupPositionsByIdQuery : IQuery<ICollection<JobGroupPosition>>
    {
        public int Id { get; set; }
    }

    public class GetJobGroupPositionsByIdQueryHandler : IQueryHandler<GetJobGroupPositionsByIdQuery, ICollection<JobGroupPosition>>
    {
        private readonly CctDbContext _db;

        public GetJobGroupPositionsByIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<ICollection<JobGroupPosition>> HandleAsync(GetJobGroupPositionsByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobGroups.Where(e => e.Id == query.Id).Select(y => y.JobGroupPositions).FirstOrDefaultAsync(cancellationToken);
        }
    }
}