using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using Business.Dtos.Similar;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.Similar
{
    public class GetAllSeventyPercentSimilarJobPositionsByJobPositionIdQuery : IQuery<SimilarSearchDto>
    {
        public int JobPositionId { get; set; }
    }
    public class GetAllSeventyPercentSimilarJobPositionsByJobPositionIdQueryHandler : IQueryHandler<GetAllSeventyPercentSimilarJobPositionsByJobPositionIdQuery, SimilarSearchDto>
    {
        private readonly CctDbContext _db;

        public GetAllSeventyPercentSimilarJobPositionsByJobPositionIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task<SimilarSearchDto> HandleAsync(GetAllSeventyPercentSimilarJobPositionsByJobPositionIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return await _db.SearchSimilarJobs.Where(e => e.Position == query.JobPositionId)
                .Select(e => new SimilarSearchDto() { SimilarPositionIds = e.SeventyPercent }).FirstOrDefaultAsync(cancellationToken);
        }
    }
}