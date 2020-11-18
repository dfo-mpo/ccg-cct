using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Business.Queries.Dtos;
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
                    JobLevelId = e.JobGroupLevel.Id,
                    JobLevelValue = e.JobGroupLevel.LevelValue,
                    JobGroupCodeEng = e.JobGroup.CodeEng,
                    JobGroupCodeFre = e.JobGroup.CodeFre,
                    JobGroupLevelId = e.JobGroupLevelId,
                    JobGroupLevelValue = e.JobGroupLevel.LevelValue,
                    
                    JobTitleId = e.JobPositionId,
                    JobTitleFre = e.JobPosition.TitleFre,
                    JobTitleEng = e.JobPosition.TitleEng

                }).FirstOrDefaultAsync(cancellationToken);
        }
    }
}
