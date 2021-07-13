using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;

namespace Business.Commands.Admin.JobPositions
{
    public class DeleteJobPositionByIdCommand : ICommand
    {
        public int Id { get; set; }
    }
    public class DeleteJobPositionByIdCommandValidator : AbstractCommandValidator<DeleteJobPositionByIdCommand>
    {
        public DeleteJobPositionByIdCommandValidator(CctDbContext db)
        {
            RuleFor(e => e.Id)
                  .NotEmpty();
        }
    }
    public class DeleteJobPositionByIdCommandHandler : ICommandHandler<DeleteJobPositionByIdCommand>
    {
        private readonly CctDbContext _db;

        public DeleteJobPositionByIdCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(DeleteJobPositionByIdCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var jobposition = await _db.JobPositions.FindAsync(command.Id);
            jobposition.Active = 0;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}