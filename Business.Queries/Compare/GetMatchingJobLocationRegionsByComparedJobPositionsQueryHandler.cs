using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;
using Business.Dtos.JobPositions;

namespace Business.Queries.Compare
{
    public class GetMatchingJobLocationRegionsByComparedJobPositionsQuery : IQuery<List<JobLocationRegionDto>>
    {
        public int PositionId { get; set; }
        public int ObjectiveId { get; set; }
    }

    public class GetMatchingJobLocationRegionsByComparedJobPositionsQueryHandler : IQueryHandler<GetMatchingJobLocationRegionsByComparedJobPositionsQuery, List<JobLocationRegionDto>>
    {
        private readonly CctDbContext _db;

        public GetMatchingJobLocationRegionsByComparedJobPositionsQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobLocationRegionDto>> HandleAsync(GetMatchingJobLocationRegionsByComparedJobPositionsQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return (from pos in _db.JobRolePositionLocations.Where(e => e.JobPositionId == query.PositionId)
                    join obj in _db.JobRolePositionLocations.Where(e => e.JobPositionId == query.ObjectiveId)
                    on pos.JobLocationRegionId equals obj.JobLocationRegionId
                    orderby obj.JobLocationRegionId
                    select new JobLocationRegionDto()
                    {
                        NameEng = pos.JobLocationRegion.NameEng,
                        NameFre = pos.JobLocationRegion.NameFre,
                        JobLocationRegionId = pos.JobLocationRegionId

                    }).ToListAsync(cancellationToken);
        }

    }
}