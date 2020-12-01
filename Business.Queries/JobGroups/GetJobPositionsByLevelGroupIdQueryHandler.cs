using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Data.Classes.JobPositions;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobGroups
{
    public class GetJobPositionsByLevelGroupIdQuery: IQuery<List<JobPositionDto>>
    {
        public int Id { get; set; }
        public int level { get; set; }
    }

    public class GetJobPositionsByLevelGroupIdQueryHandler : IQueryHandler<GetJobPositionsByLevelGroupIdQuery, List<JobPositionDto>>
    {
        private readonly CctDbContext _db;

        public GetJobPositionsByLevelGroupIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobPositionDto>> HandleAsync(GetJobPositionsByLevelGroupIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobGroupPositions.Where(e => e.JobGroupId == query.Id && e.JobGroupLevelId == query.level)
                            .Include(e => e.JobGroup)
                            .Include(e => e.JobGroupLevel)
                            .Select(e => new JobPositionDto()
                            {
                                JobGroupId = e.JobGroupId,
                                JobGroupCode = e.JobGroup.Code,
                                JobGroupLevelId = e.JobGroupLevelId,
                                JobGroupLevelValue = e.JobGroupLevel.LevelValue,
                                JobTitleId = e.JobPositionId,
                                JobTitleFre = e.JobPosition.TitleFre,
                                JobTitleEng = e.JobPosition.TitleEng,
                            }).ToListAsync(cancellationToken);

        }
    }
}