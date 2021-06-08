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
    public class GetSubGroupLevelsByIdQuery : IQuery<List<JobGroupPositionDto>>
    {
        public int Id { get; set; }
    }

    public class GetSubGroupLevelsByIdQueryHandler : IQueryHandler<GetSubGroupLevelsByIdQuery, List<JobGroupPositionDto>>
    {
        private readonly CctDbContext _db;

        public GetSubGroupLevelsByIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobGroupPositionDto>> HandleAsync(GetSubGroupLevelsByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobGroupPositions.Where(e => e.JobGroupId == query.Id)
                .Include(e => e.JobGroupLevel)
                .Include(e => e.SubJobGroup)
                .Select(e => new JobGroupPositionDto()
                {
                    LevelId = e.JobGroupLevelId,
                    LevelValue = e.JobGroupLevel.LevelValue,
                    SubGroupCode = e.SubJobGroup.SubCode,
                    JobGroupId = e.JobGroupId,
                    SubJobGroupId = e.SubJobGroupId,
                    LevelCode = string.IsNullOrEmpty(e.SubJobGroup.SubCode) ? e.JobGroup.Code + ' ' + e.JobGroupLevel.LevelValue : e.SubJobGroup.SubCode + ' ' + e.JobGroupLevel.LevelValue
                }).Distinct()
                .ToListAsync(cancellationToken);
        }
    }
}
