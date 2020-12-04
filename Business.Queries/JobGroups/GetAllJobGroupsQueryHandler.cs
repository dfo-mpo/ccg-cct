using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobGroups;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobGroups
{
    public class GetAllJobGroupsQueryHandler : IQueryHandler<List<JobGroupDto>>
    {
        private readonly CctDbContext _db;

        public GetAllJobGroupsQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobGroupDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobGroups
                .Select(e => new JobGroupDto()
                {
                    Id = e.Id,
                    Code = e.Code,
                    NameEng = e.NameEng,
                    NameFre = e.NameFre,

                }).ToListAsync(cancellationToken);
        }
    }
}
