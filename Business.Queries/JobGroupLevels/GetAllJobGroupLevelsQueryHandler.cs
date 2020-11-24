using System;
using System.Collections.Generic;
using System.Data;
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
    public class GetAllJobGroupLevelsQueryHandler : IQueryHandler<List<JobGroupLevelDto>>
    {
        private readonly CctDbContext _db;

        public GetAllJobGroupLevelsQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobGroupLevelDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobGroupLevels
                .Select(e => new JobGroupLevelDto()
                {
                    Id = e.Id,
                    LevelValue = e.LevelValue

                }).ToListAsync(cancellationToken);
        }
    }
}
