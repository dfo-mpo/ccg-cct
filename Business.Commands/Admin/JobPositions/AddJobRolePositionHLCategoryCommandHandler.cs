using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.JobPositions
{
    public class AddJobRolePositionHLCategoryCommand : ICommand
    {
        public int JobGroupId { get; set; }
        public int SubJobGroupId { get; set; }

        public int JobGroupLevelId { get; set; }

        public int JobPositionId { get; set; }

        public int JobHLCategoryId { get; set; }
    }

    public class AddJobRolePositionHLCategoryCommandValidator : AbstractCommandValidator<AddJobRolePositionHLCategoryCommand>
    {
        public AddJobRolePositionHLCategoryCommandValidator(CctDbContext db)
        {
            RuleFor(e => e.JobPositionId)
                  .NotEmpty();
            RuleFor(e => e.JobHLCategoryId)
                  .NotEmpty();
        }
    }
    public class AddJobRolePositionHLCategoryCommandHandler : ICommandHandler<AddJobRolePositionHLCategoryCommand>
    {
        private readonly CctDbContext _db;

        public AddJobRolePositionHLCategoryCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(AddJobRolePositionHLCategoryCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            await _db.JobRolePositionHLCategories.AddAsync(new JobRolePositionHLCategory()
            {
                JobGroupId = command.JobGroupId,
                JobGroupLevelId = command.JobGroupLevelId,
                JobPositionId = command.JobPositionId,
                JobHLCategoryId = command.JobHLCategoryId,
                SubJobGroupId = command.SubJobGroupId
            }, cancellationToken);

            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}