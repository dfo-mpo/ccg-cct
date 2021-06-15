using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using Business.Dtos.JobGroups;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobGroupTitles
{
    public class GetAllJobGroupTitlesQueryHandler : IQueryHandler<List<JobGroupTitleDto>>
    {
        private readonly CctDbContext _db;

        public GetAllJobGroupTitlesQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobGroupTitleDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobPositions
                .Select(e => new JobGroupTitleDto()
                {
                    Id = e.Id,
                    TitleNameFre = e.TitleFre,
                    TitleNameEng = e.TitleEng,
                    Active = e.Active

                }).ToListAsync(cancellationToken);
        }
    }
}
