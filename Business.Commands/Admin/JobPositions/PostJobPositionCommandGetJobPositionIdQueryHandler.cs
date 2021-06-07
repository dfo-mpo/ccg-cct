using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Commands.Admin.JobPositions
{
    public class PostJobPositionCommandGetJobPositionIdQuery : IQuery<int>
    {
        public string TitleEng { get; set; }
        public string TitleFre { get; set; }
    }
    public class PostJobPositionCommandGetJobPositionIdQueryHandler : IQueryHandler<PostJobPositionCommandGetJobPositionIdQuery, int>
    {
        private readonly CctDbContext _db;

        public PostJobPositionCommandGetJobPositionIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task<int> HandleAsync(PostJobPositionCommandGetJobPositionIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            var newjobposition = new JobPosition()
            {
                TitleEng = query.TitleEng,
                TitleFre = query.TitleFre,
                Active = 1
            };
            await _db.JobPositions.AddAsync(newjobposition, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return await _db.JobPositions.Where(e => e.TitleEng == query.TitleEng || e.TitleFre == query.TitleFre)
                    .Select(e => e.Id)
                    .FirstOrDefaultAsync(cancellationToken);
        }
    }
}