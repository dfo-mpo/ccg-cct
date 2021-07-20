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
    public class GetJobGroupLevelTitlesByIdQuery : IQuery<List<JobGroupPositionDto>>
    {
        public int Id { get; set; }
    }

    public class GetJobGroupLevelTitlesByIdQueryHandler : IQueryHandler<GetJobGroupLevelTitlesByIdQuery, List<JobGroupPositionDto>>
    {
        private readonly CctDbContext _db;

        public GetJobGroupLevelTitlesByIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobGroupPositionDto>> HandleAsync(GetJobGroupLevelTitlesByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobRoles.Where(e => e.JobGroupId == query.Id)
                .Include(e => e.JobGroupLevel)
                .Include(e => e.SubJobGroup)
                .Select(e => new JobGroupPositionDto()
                {
                    LevelId = e.JobGroupLevelId,
                    LevelValue = e.JobGroupLevel.LevelValue,
                    SubGroupCode = e.SubJobGroup.SubCode,
                    JobGroupId = e.JobGroupId,
                    SubJobGroupId = e.SubJobGroupId,
                    LevelCode = string.IsNullOrEmpty(e.SubJobGroup.SubCode) ? e.JobGroup.Code + '-' + e.JobGroupLevel.LevelValue : e.SubJobGroup.SubCode + '-' + e.JobGroupLevel.LevelValue,
                    Active = string.IsNullOrEmpty(e.SubJobGroup.SubCode) ? e.JobGroupLevel.Active : e.SubJobGroup.Active
                }).Distinct()
                .ToListAsync(cancellationToken);
        }
    }
}

