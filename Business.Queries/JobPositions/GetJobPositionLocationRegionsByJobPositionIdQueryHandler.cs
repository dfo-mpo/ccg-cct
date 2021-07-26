using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;
using Business.Dtos.JobPositions;

namespace Business.Queries.JobPositions
{
    public class GetJobPositionLocationRegionsByJobPositionIdQuery : IQuery<List<JobLocationRegionDto>>
    {
        public int Id { get; set; }
    }
    public class GetJobPositionLocationRegionsByJobPositionIdQueryHandler : IQueryHandler<GetJobPositionLocationRegionsByJobPositionIdQuery, List<JobLocationRegionDto>>
    {
        private readonly CctDbContext _db;

        public GetJobPositionLocationRegionsByJobPositionIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobLocationRegionDto>> HandleAsync(GetJobPositionLocationRegionsByJobPositionIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobRolePositionLocations.Where(e => e.JobPositionId == query.Id)
                    .Include(e => e.JobLocationRegion)
                    .Select(e => new JobLocationRegionDto
                    {
                        NameEng = e.JobLocationRegion.NameEng,
                        NameFre = e.JobLocationRegion.NameFre,
                        JobPositionId = e.JobPositionId,
                        JobLocationRegionId = e.JobLocationRegionId
                    }
                    ).ToListAsync(cancellationToken);
        }
    }
}