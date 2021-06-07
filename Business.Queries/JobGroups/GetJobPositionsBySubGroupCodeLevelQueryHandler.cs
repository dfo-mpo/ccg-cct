using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobGroups
{
    public class GetJobPositionsBySubGroupCodeLevelQuery : IQuery<List<JobPositionDto>>
    {
        public int Id { get; set; }
        public string subgroupcode { get; set; }
        public string level { get; set; }
    }

    public class GetJobPositionsBySubGroupCodeLevelQueryHandler : IQueryHandler<GetJobPositionsBySubGroupCodeLevelQuery, List<JobPositionDto>>
    {
        private readonly CctDbContext _db;

        public GetJobPositionsBySubGroupCodeLevelQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobPositionDto>> HandleAsync(GetJobPositionsBySubGroupCodeLevelQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobGroupPositions.Where(e => e.JobGroupId == query.Id && e.JobGroupLevel.LevelValue == query.level && e.SubJobGroup.SubCode==query.subgroupcode)
                            .Include(e => e.JobGroup)
                            .Include(e => e.JobGroupLevel)
                            .Include(e => e.JobPosition)
                            .Select(e => new JobPositionDto()
                            {
                                JobGroupId = e.JobGroupId,
                                JobGroupCode = e.JobGroup.Code,
                                JobGroupLevelId = e.JobGroupLevelId,
                                JobGroupLevelValue = e.JobGroupLevel.LevelValue,
                                JobLevelValue = e.JobGroupLevel.LevelValue,
                                JobTitleId = e.JobPositionId,
                                JobTitleFre = e.JobPosition.TitleFre,
                                JobTitleEng = e.JobPosition.TitleEng,
                            }).ToListAsync(cancellationToken);

        }
    }
}