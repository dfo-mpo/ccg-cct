using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.Similar;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.Similar
{
    public class GetAllNinetyPercentSimilarJobPositionsByJobPositionIdQuery : IQuery<SimilarSearchDto>
    {
        public int JobPositionId { get; set; }
    }
    public class GetAllNinetyPercentSimilarJobPositionsByJobPositionIdQueryHandler : IQueryHandler<GetAllNinetyPercentSimilarJobPositionsByJobPositionIdQuery, SimilarSearchDto>
    {
        private readonly CctDbContext _db;

        public GetAllNinetyPercentSimilarJobPositionsByJobPositionIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task<SimilarSearchDto> HandleAsync(GetAllNinetyPercentSimilarJobPositionsByJobPositionIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return await _db.SearchSimilarJobs.Where(e => e.Position == query.JobPositionId)
                .Select(e => new SimilarSearchDto() { SimilarPositionIds = e.NinetyPercent }).FirstOrDefaultAsync(cancellationToken);
        }
    }
}