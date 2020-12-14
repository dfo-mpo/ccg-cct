using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobPositions
{
    public class GetAllJobPositionsQueryHandler : IQueryHandler<List<JobPositionDto>>
    {
        private readonly CctDbContext _db;

        public GetAllJobPositionsQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobPositionDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobGroupPositions
                .Include(e => e.JobGroup)
                .Include(e=>e.JobGroupLevel)
                .Include(e => e.JobPosition)
                .Select(e => new JobPositionDto()
                {
                    JobGroupId = e.JobGroupId,
                    JobGroupCode = e.JobGroup.Code,
                    JobGroupLevelId = e.JobGroupLevelId,
                    JobGroupLevelValue = e.JobGroupLevel.LevelValue,
                    JobTitleId = e.JobPositionId,
                    JobTitleFre = e.JobPosition.TitleFre,
                    JobTitleEng = e.JobPosition.TitleEng

                }).ToListAsync(cancellationToken);
        }
    }
}
