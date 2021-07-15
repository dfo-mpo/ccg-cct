using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.JobPositions
{
    public class UpdateJobRolePositionCompetencyCommand : ICommand
    {
        public int JobPositionId { get; set; }
        public int CompetencyId { get; set; }
        public int CompetencyTypeId { get; set; }
        public int JobGroupId { get; set; }
        public int JobGroupLevelId { get; set; }
        public int CompetencyRatingLevelId { get; set; }
        public int CompetencyLevelRequirementId { get; set; }
    }

    public class UpdateJobRolePositionCompetencyCommandValidator : AbstractCommandValidator<UpdateJobRolePositionCompetencyCommand>
    {
        public UpdateJobRolePositionCompetencyCommandValidator(CctDbContext db)
        {
            RuleFor(e => e.JobPositionId)
                 .NotEmpty();
        }
    }
    public class UpdateJobRolePositionCompetencyCommandHandler : ICommandHandler<UpdateJobRolePositionCompetencyCommand>
    {
        private readonly CctDbContext _db;

        public UpdateJobRolePositionCompetencyCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(UpdateJobRolePositionCompetencyCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var jobposition = _db.JobPositionCompetencies.First(e => e.JobPositionId == command.JobPositionId);
            jobposition.CompetencyId = command.CompetencyId;
            jobposition.CompetencyTypeId = command.CompetencyTypeId;
            await _db.SaveChangesAsync(cancellationToken);

            var jobroleposition = _db.JobRolePositionCompetencies.First(e => e.JobPositionId == command.JobPositionId);
            jobroleposition.CompetencyId = command.CompetencyId;
            jobroleposition.CompetencyTypeId = command.CompetencyTypeId;
            jobroleposition.JobGroupId = command.JobGroupId;
            jobroleposition.JobGroupLevelId = command.JobGroupLevelId;
            await _db.SaveChangesAsync(cancellationToken);

            var jobrolepositionratings = _db.JobRolePositionCompetencyRatings.First(e => e.JobPositionId == command.JobPositionId);

            await _db.JobRolePositionCompetencyRatings.AddAsync(new JobRolePositionCompetencyRating()
            {
                JobPositionId = command.JobPositionId,
                CompetencyId = command.CompetencyId,
                CompetencyTypeId = command.CompetencyTypeId,
                JobGroupId = command.JobGroupId,
                JobGroupLevelId = command.JobGroupLevelId,
                CompetencyRatingLevelId = command.CompetencyRatingLevelId,
                CompetencyLevelRequirementId = command.CompetencyLevelRequirementId
            }, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
