using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.JobPositions
{
    public class AddJobRolePositionCompetencyCommand : ICommand
    {
        public int JobPositionId { get; set; }
        public int CompetencyId { get; set; }
        public int CompetencyTypeId { get; set; }
        public int JobGroupId { get; set; }
        public int SubJobGroupId { get; set; }
        public int JobGroupLevelId { get; set; }
        public int CompetencyRatingLevelId { get; set; }
        public int CompetencyLevelRequirementId { get; set; }
    }

    public class AddJobRolePositionCompetencyCommandValidator : AbstractCommandValidator<AddJobRolePositionCompetencyCommand>
    {
        public AddJobRolePositionCompetencyCommandValidator(CctDbContext db)
        {

        }
    }
    public class AddJobRolePositionCompetencyCommandHandler : ICommandHandler<AddJobRolePositionCompetencyCommand>
    {
        private readonly CctDbContext _db;

        public AddJobRolePositionCompetencyCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(AddJobRolePositionCompetencyCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            await _db.JobPositionCompetencies.AddAsync(new JobPositionCompetency()
            {
                JobPositionId = command.JobPositionId,
                CompetencyId = command.CompetencyId,
                CompetencyTypeId = command.CompetencyTypeId
            }, cancellationToken);
            await _db.JobRolePositionCompetencies.AddAsync(new JobRolePositionCompetency()
            {
                JobPositionId = command.JobPositionId,
                CompetencyId = command.CompetencyId,
                CompetencyTypeId = command.CompetencyTypeId,
                JobGroupId = command.JobGroupId,
                JobGroupLevelId = command.JobGroupLevelId,
                SubJobGroupId = command.SubJobGroupId,
            }, cancellationToken);
            await _db.JobRolePositionCompetencyRatings.AddAsync(new JobRolePositionCompetencyRating()
            {
                JobPositionId = command.JobPositionId,
                CompetencyId = command.CompetencyId,
                CompetencyTypeId = command.CompetencyTypeId,
                JobGroupId = command.JobGroupId,
                JobGroupLevelId = command.JobGroupLevelId,
                CompetencyRatingLevelId = command.CompetencyRatingLevelId,
                CompetencyLevelRequirementId = command.CompetencyLevelRequirementId,
                SubJobGroupId = command.SubJobGroupId
            }, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
