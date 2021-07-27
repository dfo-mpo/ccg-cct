using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobGroups;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobGroups
{
    public class GetAllJobGroupsByJobHLCategoryIdQuery : IQuery<List<JobGroupDto>>
    {
        public int JobHLCategoryId { get; set; }
    }
    public class GetAllJobGroupsByJobHLCategoryIdQueryHandler : IQueryHandler<GetAllJobGroupsByJobHLCategoryIdQuery, List<JobGroupDto>>
    {
        private readonly CctDbContext _db;

        public GetAllJobGroupsByJobHLCategoryIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobGroupDto>> HandleAsync(GetAllJobGroupsByJobHLCategoryIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobRolePositionHLCategories.Where(e => e.JobHLCategoryId == query.JobHLCategoryId && e.JobPosition.Active != 0)
                .Include(e => e.JobGroup)
                .Select(e => new JobGroupDto()
                {
                    Id = e.JobGroupId,
                    Code = e.JobGroup.Code,
                    NameEng = e.JobGroup.NameEng,
                    NameFre = e.JobGroup.NameFre,
                    Active = e.JobPosition.Active

                }).Distinct().ToListAsync(cancellationToken);
        }
    }
}
