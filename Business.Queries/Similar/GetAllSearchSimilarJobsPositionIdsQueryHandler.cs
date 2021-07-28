using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.Similar
{
    public class GetAllSearchSimilarJobsPositionIdsQueryHandler : IQueryHandler<List<int>>
    {
        private readonly CctDbContext _db;

        public GetAllSearchSimilarJobsPositionIdsQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<int>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.SearchSimilarJobs
                    .Select(e => e.Position)
                    .ToListAsync(cancellationToken);
        }
    }
}
