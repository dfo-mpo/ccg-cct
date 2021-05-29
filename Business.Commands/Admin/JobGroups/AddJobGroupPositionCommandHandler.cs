using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.JobGroups
{
    public class AddJobGroupPositionCommand : ICommand
    {
        public int JobPositionId { get; set; }
        public int JobGroupId { get; set; }
        public int JobGroupLevelId { get; set; }
    }

    public class AddJobGroupPositionCommandValidator : AbstractCommandValidator<AddJobGroupPositionCommand>
    {
        public AddJobGroupPositionCommandValidator(CctDbContext db)
        {
        }
    }
    public class AddJobGroupPositionCommandHandler : ICommandHandler<AddJobGroupPositionCommand>
    {
        private readonly CctDbContext _db;

        public AddJobGroupPositionCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(AddJobGroupPositionCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            await _db.JobGroupPositions.AddAsync(new JobGroupPosition()
            {
                JobPositionId = command.JobPositionId,
                JobGroupId = command.JobGroupId,
                JobGroupLevelId = command.JobGroupLevelId
            }, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
        }

    }
}
