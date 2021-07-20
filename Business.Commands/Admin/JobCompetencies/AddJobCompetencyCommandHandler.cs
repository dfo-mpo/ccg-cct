using CCG.AspNetCore.Business.Interface;
using DataModel;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Commands.Admin.JobCompetencies
{
    public class AddJobCompetencyCommand : IQuery<int>
    {
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


    public class AddJobCompetencyCommandHandler : IQueryHandler<AddJobCompetencyCommand,int>
    {
        private readonly CctDbContext _db;
        public AddJobCompetencyCommandHandler(CctDbContext db)
        {
            _db = db;
        }
        public async Task<int> HandleAsync(AddJobCompetencyCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var newCompetency = new Competency()
            {
                NameEng = command.NameEng,
                NameFre = command.NameFre,
                DescEng = command.DescEng,
                DescFre = command.DescFre,
                Active = 1
            };
            var lr1 = new CompetencyLevelRequirement()
            {
                DescEng = command.Level1DescEng,
                DescFre = command.Level1DescFre,
            };
            var lr2 = new CompetencyLevelRequirement()
            {
                DescEng = command.Level2DescEng,
                DescFre = command.Level2DescFre
            };
            var lr3 = new CompetencyLevelRequirement()
            {
                DescEng = command.Level3DescEng,
                DescFre = command.Level3DescFre
            };
            var lr4 = new CompetencyLevelRequirement()
            {
                DescEng = command.Level4DescEng,
                DescFre = command.Level4DescFre
            };
            var lr5 = new CompetencyLevelRequirement()
            {
                DescEng = command.Level5DescEng,
                DescFre = command.Level5DescFre
            };

            await _db.Competencies.AddAsync(newCompetency, cancellationToken);
            await _db.CompetencyLevelRequirements.AddAsync(lr1, cancellationToken);
            await _db.CompetencyLevelRequirements.AddAsync(lr2, cancellationToken);
            await _db.CompetencyLevelRequirements.AddAsync(lr3, cancellationToken);
            await _db.CompetencyLevelRequirements.AddAsync(lr4, cancellationToken);
            await _db.CompetencyLevelRequirements.AddAsync(lr5, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            var execlevelinc = command.TypeId == 4 ? 5 : 0;
            var typegroup = new CompetencyTypeGroup()
            {
                CompetencyId = newCompetency.Id,
                CompetencyTypeId = command.TypeId
            };
            await _db.CompetencyTypeGroups.AddAsync(typegroup, cancellationToken);
            await _db.CompetencyRatingGroups.AddAsync(new CompetencyRatingGroup()
            {
                CompetencyId = newCompetency.Id,
                CompetencyRatingLevelId = 1 + execlevelinc,
                CompetencyLevelRequirementId = lr1.Id
            }, cancellationToken);
            await _db.CompetencyRatingGroups.AddAsync(new CompetencyRatingGroup()
            {
                CompetencyId = newCompetency.Id,
                CompetencyRatingLevelId = 2 + execlevelinc,
                CompetencyLevelRequirementId = lr2.Id,
            }, cancellationToken);
            await _db.CompetencyRatingGroups.AddAsync(new CompetencyRatingGroup()
            {
                CompetencyId = newCompetency.Id,
                CompetencyRatingLevelId = 3 + execlevelinc,
                CompetencyLevelRequirementId = lr3.Id
            }, cancellationToken);
            await _db.CompetencyRatingGroups.AddAsync(new CompetencyRatingGroup()
            {
                CompetencyId = newCompetency.Id,
                CompetencyRatingLevelId = 4 + execlevelinc,
                CompetencyLevelRequirementId = lr4.Id
            }, cancellationToken);
            await _db.CompetencyRatingGroups.AddAsync(new CompetencyRatingGroup()
            {
                CompetencyId = newCompetency.Id,
                CompetencyRatingLevelId = 5 + execlevelinc,
                CompetencyLevelRequirementId = lr5.Id
            }, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);

            return newCompetency.Id;
        }

    }
}

