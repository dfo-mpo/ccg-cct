using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobGroups;
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
                .Include(e => e.SubJobGroup)
                .Select(e=> new JobGroupPositionDto(){
                    JobId = e.JobPositionId,
                    LevelId = e.JobGroupLevelId,
                    LevelValue = e.JobGroupLevel.LevelValue,
                    SubGroupCode = e.SubJobGroup.SubCode,
                    LevelCode = string.IsNullOrEmpty(e.SubJobGroup.SubCode) ? e.JobGroup.Code + '-' + e.JobGroupLevel.LevelValue : e.SubJobGroup.SubCode + '-' + e.JobGroupLevel.LevelValue,
                    Active = e.JobPosition.Active
                })
                .ToListAsync(cancellationToken);
        }
    }
}