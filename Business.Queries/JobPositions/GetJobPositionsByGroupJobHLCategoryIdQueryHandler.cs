using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobPositions
{
    public class GetJobPositionsByGroupJobHLCategoryIdQuery : IQuery<List<JobPositionDto>>
    {
        public int JobGroupId { get; set; }
        public int JobHLCategoryId { get; set; }
    }

    public class GetJobPositionsByGroupJobHLCategoryIdQueryHandler : IQueryHandler<GetJobPositionsByGroupJobHLCategoryIdQuery, List<JobPositionDto>>
    {
        private readonly CctDbContext _db;

        public GetJobPositionsByGroupJobHLCategoryIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobPositionDto>> HandleAsync(GetJobPositionsByGroupJobHLCategoryIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobRolePositionHLCategories.Where(e => e.JobGroupId == query.JobGroupId)
                            .Where(e => e.JobHLCategoryId == query.JobHLCategoryId)
                            .Include(e => e.JobGroup)
                            .Include(e => e.SubJobGroup)
                            .Include(e => e.JobGroupLevel)
                            .Include(e => e.JobPosition)
                            .Select(e => new JobPositionDto()
                            {
                                JobGroupId = e.JobGroupId,
                                JobGroupCode = e.JobGroup.Code,
                                JobGroupLevelId = e.JobGroupLevelId,
                                JobLevelValue = e.JobGroupLevel.LevelValue,
                                JobGroupLevelCode = string.IsNullOrEmpty(e.SubJobGroup.SubCode) ? e.JobGroup.Code + '-' + e.JobGroupLevel.LevelValue : e.JobGroup.Code + '-' + e.SubJobGroup.SubCode + '-' + e.JobGroupLevel.LevelValue,
                                LevelCode = string.IsNullOrEmpty(e.SubJobGroup.SubCode) ? e.JobGroup.Code + '-' + e.JobGroupLevel.LevelValue : e.SubJobGroup.SubCode + '-' + e.JobGroupLevel.LevelValue,
                                JobTitleId = e.JobPositionId,
                                JobTitleFre = e.JobPosition.TitleFre,
                                JobTitleEng = e.JobPosition.TitleEng,
                                JobDescriptionFre = e.JobPosition.PositionDescFre,
                                JobDescriptionEng = e.JobPosition.PositionDescEng,
                                Active = e.JobPosition.Active
                            }).ToListAsync(cancellationToken);

        }
    }
}