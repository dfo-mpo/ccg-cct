using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.JobCompetencies
{
    public class UpdateJobCompetencyCommand : ICommand
    {
        public int Id { get; set; }
        public string NameEng { get; set; }
        public string NameFre { get; set; }
        public string DescEng { get; set; }
        public string DescFre { get; set; }
        public int TypeId { get; set; }
        public string Level1DescEng { get; set; }
        public string Level1DescFre { get; set; }
        public string Level2DescEng { get; set; }
        public string Level2DescFre { get; set; }
        public string Level3DescEng { get; set; }
        public string Level3DescFre { get; set; }
        public string Level4DescEng { get; set; }
        public string Level4DescFre { get; set; }
        public string Level5DescEng { get; set; }
        public string Level5DescFre { get; set; }
    }

    public class UpdateJobCompetencyCommandValidator : AbstractCommandValidator<UpdateJobCompetencyCommand>
    {
        public UpdateJobCompetencyCommandValidator(CctDbContext db)
        {
            RuleFor(e => e.NameEng)
                .MaximumLength(1000);
            RuleFor(e => e.NameFre)
                .MaximumLength(1000);
            RuleFor(e => e.DescEng)
                .MaximumLength(2500);
            RuleFor(e => e.DescFre)
                .MaximumLength(2500);
        }
    }
    public class UpdateJobCompetencyCommandHandler : ICommandHandler<UpdateJobCompetencyCommand>
    {
        private readonly CctDbContext _db;

        public UpdateJobCompetencyCommandHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(UpdateJobCompetencyCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var jobcompetency = _db.Competencies.First(e => e.Id == command.Id);
            jobcompetency.NameEng = command.NameEng;
            jobcompetency.NameFre = command.NameFre;
            jobcompetency.DescEng = string.IsNullOrEmpty(command.DescEng) ? string.Empty : command.DescEng;
            jobcompetency.DescFre = string.IsNullOrEmpty(command.DescFre) ? string.Empty : command.DescFre;
            var execlevelinc = command.TypeId == 4 ? 5 : 0;
            var crg1 = _db.CompetencyRatingGroups
                .Where(e => e.CompetencyId == command.Id && e.CompetencyRatingLevelId == 1 + execlevelinc).FirstOrDefault();
            var crg2 = _db.CompetencyRatingGroups
                .Where(e => e.CompetencyId == command.Id && e.CompetencyRatingLevelId == 2 + execlevelinc).FirstOrDefault();
            var crg3 = _db.CompetencyRatingGroups
                .Where(e => e.CompetencyId == command.Id && e.CompetencyRatingLevelId == 3 + execlevelinc).FirstOrDefault();
            var crg4 = _db.CompetencyRatingGroups
                .Where(e => e.CompetencyId == command.Id && e.CompetencyRatingLevelId == 4 + execlevelinc).FirstOrDefault();
            var crg5 = _db.CompetencyRatingGroups
                .Where(e => e.CompetencyId == command.Id && e.CompetencyRatingLevelId == 5 + execlevelinc).FirstOrDefault();
            var jobcompetencylevel1req = _db.CompetencyLevelRequirements.First(e => e.Id == crg1.CompetencyLevelRequirementId);
            var jobcompetencylevel2req = _db.CompetencyLevelRequirements.First(e => e.Id == crg2.CompetencyLevelRequirementId);
            var jobcompetencylevel3req = _db.CompetencyLevelRequirements.First(e => e.Id == crg3.CompetencyLevelRequirementId);
            var jobcompetencylevel4req = _db.CompetencyLevelRequirements.First(e => e.Id == crg4.CompetencyLevelRequirementId);
            var jobcompetencylevel5req = _db.CompetencyLevelRequirements.First(e => e.Id == crg5.CompetencyLevelRequirementId);
            jobcompetencylevel1req.DescEng = command.Level1DescEng;
            jobcompetencylevel1req.DescFre = command.Level1DescFre;
            jobcompetencylevel2req.DescEng = command.Level2DescEng;
            jobcompetencylevel2req.DescFre = command.Level2DescFre;
            jobcompetencylevel3req.DescEng = command.Level3DescEng;
            jobcompetencylevel3req.DescFre = command.Level3DescFre;
            jobcompetencylevel4req.DescEng = command.Level4DescEng;
            jobcompetencylevel4req.DescFre = command.Level4DescFre;
            jobcompetencylevel5req.DescEng = command.Level5DescEng;
            jobcompetencylevel5req.DescFre = command.Level5DescFre;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}