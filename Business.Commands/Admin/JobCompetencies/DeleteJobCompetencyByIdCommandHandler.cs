using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;

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
            var competency = await _db.Competencies.FindAsync(command.Id);
            _db.Competencies.Remove(competency);
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
