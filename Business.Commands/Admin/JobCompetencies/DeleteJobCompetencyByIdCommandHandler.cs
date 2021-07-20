using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;

namespace Business.Commands.Admin.JobCompetencies
{
    public class DeleteJobCompetencyByIdCommand : ICommand
    {
        public int Id { get; set; }
    }
    public class DeleteJobCompetencyByIdCommandValidator : AbstractCommandValidator<DeleteJobCompetencyByIdCommand>
    {
        public DeleteJobCompetencyByIdCommandValidator(CctDbContext db)
        {
            RuleFor(e => e.Id)
                .NotEmpty();
        }
    }
    public class DeleteJobCompetencyByIdCommandHandler : ICommandHandler<DeleteJobCompetencyByIdCommand>
    {
        private readonly CctDbContext _db;

        public DeleteJobCompetencyByIdCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(DeleteJobCompetencyByIdCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var jobcompetency = await _db.Competencies.FindAsync(command.Id);
            jobcompetency.Active = 0;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
