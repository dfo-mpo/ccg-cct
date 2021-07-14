using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.Similar
{
    public class UpdateSimilarPositionsCommand : ICommand
    {
        public int Position { get; set; }
        public string HundredPercent { get; set; }
        public string NinetyPercent { get; set; }
        public string EightyPercent { get; set; }
        public string SeventyPercent { get; set; }
    }

    public class UpdateSimilarPositionsCommandValidator : AbstractCommandValidator<UpdateSimilarPositionsCommand>
    {
        public UpdateSimilarPositionsCommandValidator(CctDbContext db)
        {
            RuleFor(e => e.Position)
                   .NotEmpty();
            RuleFor(e => e.HundredPercent)
                    .MaximumLength(8000);
            RuleFor(e => e.NinetyPercent)
                    .MaximumLength(8000);
            RuleFor(e => e.EightyPercent)
                    .MaximumLength(8000);
            RuleFor(e => e.SeventyPercent)
                    .MaximumLength(8000);
        }
    }
    public class UpdateSimilarPositionsCommandHandler : ICommandHandler<UpdateSimilarPositionsCommand>
    {
        private readonly CctDbContext _db;

        public UpdateSimilarPositionsCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(UpdateSimilarPositionsCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var jobposition = _db.SearchSimilarJobs.First(e => e.Position == command.Position);
            jobposition.HundredPercent = string.IsNullOrEmpty(command.HundredPercent) ? string.Empty : command.HundredPercent;
            jobposition.NinetyPercent = string.IsNullOrEmpty(command.NinetyPercent) ? string.Empty : command.NinetyPercent;
            jobposition.EightyPercent = string.IsNullOrEmpty(command.EightyPercent) ? string.Empty : command.EightyPercent;
            jobposition.SeventyPercent = string.IsNullOrEmpty(command.SeventyPercent) ? string.Empty : command.SeventyPercent;
            await _db.SaveChangesAsync(cancellationToken);
        }

    }
}
