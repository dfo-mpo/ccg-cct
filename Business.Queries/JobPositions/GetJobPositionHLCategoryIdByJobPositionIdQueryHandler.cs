using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Commands.Admin.JobPositions
{
    public class GetJobPositionHLCategoryIdByJobPositionIdQuery : IQuery<int>
    {
        public int Id { get; set; }
    }
    public class GetJobPositionHLCategoryIdByJobPositionIdQueryHandler : IQueryHandler<GetJobPositionHLCategoryIdByJobPositionIdQuery, int>
    {
        private readonly CctDbContext _db;

        public GetJobPositionHLCategoryIdByJobPositionIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<int> HandleAsync(GetJobPositionHLCategoryIdByJobPositionIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobRolePositionHLCategories.Where(e => e.JobPositionId == query.Id).Select(e => e.JobHLCategoryId).FirstOrDefaultAsync(cancellationToken);
        }
    }
}