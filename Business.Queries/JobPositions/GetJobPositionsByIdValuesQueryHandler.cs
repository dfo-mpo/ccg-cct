﻿using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobPositions
{
    public class GetJobPositionByIdValuesQuery : IQuery<List<JobPositionDto>>
    {
        public int[] Id { get; set; }
    }
    public class GetJobPositionByIdValuesQueryHandler : IQueryHandler<GetJobPositionByIdValuesQuery, List<JobPositionDto>>
    {
        private readonly CctDbContext _db;

        public GetJobPositionByIdValuesQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task<List<JobPositionDto>> HandleAsync(GetJobPositionByIdValuesQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return await _db.JobGroupPositions.Where(e => query.Id.Contains(e.JobPositionId))
                .Include(e => e.JobGroup)
                .Include(e => e.JobPosition)
                .Include(e => e.JobGroupLevel)
                .Select(e => new JobPositionDto()
                {
                    JobGroupId = e.JobGroupId,
                    JobLevelId = e.JobGroupLevel.Id,
                    JobLevelValue = e.JobGroupLevel.LevelValue,
                    JobGroupCode = e.JobGroup.Code,
                    JobGroupTitleEng = e.JobGroup.NameEng,
                    JobGroupTitleFre = e.JobGroup.NameFre,
                    JobGroupLevelId = e.JobGroupLevelId,
                    JobGroupLevelValue = e.JobGroupLevel.LevelValue,
                    JobTitleId = e.JobPositionId,
                    JobTitleFre = e.JobPosition.TitleFre,
                    JobTitleEng = e.JobPosition.TitleEng

                }).ToListAsync(cancellationToken);
        }
    }
}

