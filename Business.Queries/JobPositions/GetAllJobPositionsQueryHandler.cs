﻿using System.Collections.Generic;
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
                    SubJobGroupId = e.SubJobGroupId,
                    SubGroupCode = e.SubJobGroup.SubCode,
                    JobGroupLevelId = e.JobGroupLevelId,
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
