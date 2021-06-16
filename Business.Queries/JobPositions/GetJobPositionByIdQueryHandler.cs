using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobPositions
{
        public class GetJobPositionByIdQuery : IQuery<JobPositionDto>
        {
            public int Id { get; set; }
        }
    public class GetJobPositionByIdQueryHandler : IQueryHandler<GetJobPositionByIdQuery, JobPositionDto>
    {
        private readonly CctDbContext _db;

        public GetJobPositionByIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<JobPositionDto> HandleAsync(GetJobPositionByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobGroupPositions.Where(e=>e.JobPositionId==query.Id)
                .Include(e => e.JobGroup)
                .Include(e => e.JobPosition)
                .Include(e => e.JobGroupLevel)
                .Select(e => new JobPositionDto()
                {
                    JobGroupId = e.JobGroupId,
                    JobGroupCode = string.IsNullOrEmpty(e.SubJobGroup.SubCode) ? e.JobGroup.Code : e.SubJobGroup.SubCode,
                    SubJobGroupId = e.SubJobGroupId,
                    SubGroupCode = e.SubJobGroup.SubCode,
                    JobLevelId = e.JobGroupLevel.Id,
                    JobLevelValue = e.JobGroupLevel.LevelValue,
                    JobGroupTitleEng = e.JobGroup.NameEng,
                    JobGroupTitleFre = e.JobGroup.NameFre,
                    JobGroupLevelId = e.JobGroupLevelId,
                    JobGroupLevelValue = e.JobGroupLevel.LevelValue,                   
                    JobTitleId = e.JobPositionId,
                    JobTitleFre = e.JobPosition.TitleFre,
                    JobTitleEng = e.JobPosition.TitleEng,
                    Active = e.JobPosition.Active,

                }).FirstOrDefaultAsync(cancellationToken);
        }
    }
}
