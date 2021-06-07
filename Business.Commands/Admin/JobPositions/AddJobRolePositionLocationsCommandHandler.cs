using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.JobPositions
{
    public class AddJobRolePositionLocationsCommand : ICommand
    {
        public int JobGroupId { get; set; }
        public int SubJobGroupId { get; set; }

        public int JobGroupLevelId { get; set; }

        public int JobPositionId { get; set; }

        public int JobLocationRegionId { get; set; }
    }

    public class AddJobRolePositionLocationsCommandValidator : AbstractCommandValidator<AddJobRolePositionLocationsCommand>
    {
        public AddJobRolePositionLocationsCommandValidator(CctDbContext db)
        {

        }
    }
    public class AddJobRolePositionLocationsCommandHandler : ICommandHandler<AddJobRolePositionLocationsCommand>
    {
        private readonly CctDbContext _db;

        public AddJobRolePositionLocationsCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(AddJobRolePositionLocationsCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            await _db.JobRolePositionLocations.AddAsync(new JobRolePositionLocation()
            {
                JobGroupId = command.JobGroupId,
                JobGroupLevelId = command.JobGroupLevelId,
                JobPositionId = command.JobPositionId,
                JobLocationRegionId = command.JobLocationRegionId,
                SubJobGroupId = command.SubJobGroupId
            }, cancellationToken);

            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}