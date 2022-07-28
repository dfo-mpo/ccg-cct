using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;

namespace Business.Commands.Admin.JobPositions
{
    public class PostJobPositionCommandGetJobPositionIdQuery : IQuery<int>
    {
        public string TitleEng { get; set; }
        public string TitleFre { get; set; }
        public string PositionDescEng { get; set; }
        public string PositionDescFre { get; set; }
    }
    public class PostJobPositionCommandValidator : AbstractCommandValidator<PostJobPositionCommandGetJobPositionIdQuery>
    {
        public PostJobPositionCommandValidator(CctDbContext db)
        {
            RuleFor(e => e.TitleEng)
                .MaximumLength(3000);
            RuleFor(e => e.TitleFre)
                .MaximumLength(3000);
            RuleFor(b => b.PositionDescEng)
                 .MaximumLength(8000);
            RuleFor(b => b.PositionDescFre)
                .MaximumLength(8000);
        }
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
                PositionDescEng = string.IsNullOrEmpty(query.PositionDescEng) ? "" : query.PositionDescEng,
                PositionDescFre = string.IsNullOrEmpty(query.PositionDescFre) ? "" : query.PositionDescFre,
                Active = 1
            };
            await _db.JobPositions.AddAsync(newjobposition, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return newjobposition.Id;
        }
    }
}