using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;
using Business.Dtos.Shared;

namespace Business.Queries.Compare
{
    public class GetDifferingJobLocationRegionsByComparedJobPositionsQuery : IQuery<List<SharedJobLocationRegionDto>>
    {
        public int PositionId { get; set; }
        public int ObjectiveId { get; set; }
    }

    public class GetDifferingJobLocationRegionsByComparedJobPositionsQueryHandler : IQueryHandler<GetDifferingJobLocationRegionsByComparedJobPositionsQuery, List<SharedJobLocationRegionDto>>
    {
        private readonly CctDbContext _db;

        public GetDifferingJobLocationRegionsByComparedJobPositionsQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<SharedJobLocationRegionDto>> HandleAsync(GetDifferingJobLocationRegionsByComparedJobPositionsQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            var currentJobLocationRegionIds = _db.JobRolePositionLocations.Where(e => e.JobPositionId == query.PositionId)
                .Select(e => e.JobLocationRegionId)
                .ToList();

            var objectiveJobLocationRegionIds = _db.JobRolePositionLocations.Where(e => e.JobPositionId == query.ObjectiveId)
                .Select(e => e.JobLocationRegionId)
                .ToList();

            var currentJobLocationRegions = _db.JobRolePositionLocations
                .Where(e => e.JobPositionId == query.PositionId)
                .Where(e => currentJobLocationRegionIds.Contains(e.JobLocationRegionId))
                .Where(e => !objectiveJobLocationRegionIds.Contains(e.JobLocationRegionId))
                 .Include(e => e.JobLocationRegion)
                 .Select(e => new SharedJobLocationRegionDto()
                 {
                     NameEng = e.JobLocationRegion.NameEng,
                     NameFre = e.JobLocationRegion.NameFre,
                     Id = e.JobLocationRegionId,
                     CurrentPositionHas = "✔",
                     ObjectivePositionHas = "x",

                 });

            var objectiveJobLocationRegions = _db.JobRolePositionLocations
               .Where(e => e.JobPositionId == query.ObjectiveId)
                .Where(e => !currentJobLocationRegionIds.Contains(e.JobLocationRegionId))
                .Where(e => objectiveJobLocationRegionIds.Contains(e.JobLocationRegionId))
                .Include(e => e.JobLocationRegion)
              .Select(e => new SharedJobLocationRegionDto()
              {
                  NameEng = e.JobLocationRegion.NameEng,
                  NameFre = e.JobLocationRegion.NameFre,
                  Id = e.JobLocationRegionId,
                  CurrentPositionHas = "x",
                  ObjectivePositionHas = "✔",

              });

            return currentJobLocationRegions.Union(objectiveJobLocationRegions).ToListAsync(cancellationToken);


        }
    }
}