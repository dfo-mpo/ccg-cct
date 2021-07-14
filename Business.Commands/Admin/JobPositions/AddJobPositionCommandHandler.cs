using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.JobPositions
{
    public class AddJobPositionCommand : ICommand
    {
        public string TitleEng { get; set; }
        public string TitleFre { get; set; }
    }

    public class AddJobPositionCommandValidator : AbstractCommandValidator<AddJobPositionCommand>
    {
        public AddJobPositionCommandValidator(CctDbContext db)
        {
            RuleFor(e => e.TitleEng)
                .MaximumLength(3000);

            RuleFor(e => e.TitleFre)
                .MaximumLength(3000);
        }
    }
    public class AddJobPositionCommandHandler : ICommandHandler<AddJobPositionCommand>
    {
        private readonly CctDbContext _db;

        public AddJobPositionCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(AddJobPositionCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            await _db.JobPositions.AddAsync(new JobPosition()
            {
                TitleEng = command.TitleEng,
                TitleFre = command.TitleFre,
            }, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
        }

    }
}