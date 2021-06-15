using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.Similar
{
    public class AddSimilarPositionsCommand : ICommand
    {
        public int Position { get; set; }
        public string HundredPercent { get; set; }
        public string NinetyPercent { get; set; }
        public string EightyPercent { get; set; }
        public string SeventyPercent { get; set; }
    }

    public class AddSimilarPositionsCommandValidator : AbstractCommandValidator<AddSimilarPositionsCommand>
    {
        public AddSimilarPositionsCommandValidator(CctDbContext db)
        {
        }
    }
    public class AddSimilarPositionsCommandHandler : ICommandHandler<AddSimilarPositionsCommand>
    {
        private readonly CctDbContext _db;

        public AddSimilarPositionsCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(AddSimilarPositionsCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var jobposition = new SearchSimilarJob()
            {
                Position = command.Position,
                HundredPercent = string.IsNullOrEmpty(command.HundredPercent) ? string.Empty : command.HundredPercent,
                NinetyPercent = string.IsNullOrEmpty(command.NinetyPercent) ? string.Empty : command.NinetyPercent,
                EightyPercent = string.IsNullOrEmpty(command.EightyPercent) ? string.Empty : command.EightyPercent,
                SeventyPercent = string.IsNullOrEmpty(command.SeventyPercent) ? string.Empty : command.SeventyPercent
            };
            await _db.AddAsync(jobposition);
            await _db.SaveChangesAsync(cancellationToken);
        }

    }
}
