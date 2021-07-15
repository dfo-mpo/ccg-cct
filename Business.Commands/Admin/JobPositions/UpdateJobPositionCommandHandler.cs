using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.JobPositions
{
    public class UpdateJobPositionCommand : ICommand
    {
        public int Id { get; set; }
        public string TitleEng { get; set; }
        public string TitleFre { get; set; }
    }


    public class UpdateJobPositionCommandValidator : AbstractCommandValidator<UpdateJobPositionCommand>
    {
        public UpdateJobPositionCommandValidator(CctDbContext db)
        {
            RuleFor(e => e.Id)
                .NotEmpty();
            RuleFor(e => e.TitleEng)
                .MaximumLength(3000);

            RuleFor(e => e.TitleFre)
                .MaximumLength(3000);
        }
    }
    public class UpdateJobPositionCommandHandler : ICommandHandler<UpdateJobPositionCommand>
    {
        private readonly CctDbContext _db;

        public UpdateJobPositionCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(UpdateJobPositionCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var jobposition = _db.JobPositions.First(e => e.Id == command.Id);
            jobposition.TitleEng = command.TitleEng;
            jobposition.TitleFre = command.TitleFre;
            await _db.SaveChangesAsync(cancellationToken);
        }

    }
}
