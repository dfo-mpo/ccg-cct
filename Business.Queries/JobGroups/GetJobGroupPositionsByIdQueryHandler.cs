using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Data.Classes.JobGroups;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobGroups
{
    public class GetJobGroupPositionsByIdQuery : IQuery<List<JobGroupPositionDto>>
    {
        public int Id { get; set; }
    }

    public class GetJobGroupPositionsByIdQueryHandler : IQueryHandler<GetJobGroupPositionsByIdQuery, List<JobGroupPositionDto>>
    {
        private readonly CctDbContext _db;

        public GetJobGroupPositionsByIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobGroupPositionDto>> HandleAsync(GetJobGroupPositionsByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobGroupPositions.Where(e => e.JobGroupId == query.Id)
                .Include(e => e.JobGroupLevel)
                .Select(e=> new JobGroupPositionDto(){
                    JobId = e.JobPositionId,
                    LevelId = e.JobGroupLevelId,
                    LevelValue = e.JobGroupLevel.LevelValue              
            })
                .ToListAsync(cancellationToken);
        }
    }
}