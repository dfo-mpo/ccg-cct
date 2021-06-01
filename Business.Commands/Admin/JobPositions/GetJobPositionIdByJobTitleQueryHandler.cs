using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Commands.Admin.JobPositions
{
    public class GetJobPositionIdByJobTitleQuery : IQuery<int>
    {
        public string Title { get; set; }
    }
    public class GetJobPositionIdByJobTitleQueryHandler : IQueryHandler<GetJobPositionIdByJobTitleQuery, int>
    {
        private readonly CctDbContext _db;

        public GetJobPositionIdByJobTitleQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<int> HandleAsync(GetJobPositionIdByJobTitleQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobPositions.Where(e => e.TitleEng == query.Title || e.TitleFre == query.Title)
                    .Select(e =>  e.Id)
                    .FirstOrDefaultAsync(cancellationToken);
        }
    }
}