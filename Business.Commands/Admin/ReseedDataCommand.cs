using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using DataModel.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Business.Commands.Admin
{
    public class ReseedDataCommand : ICommand
    {
    }

    public class ReseedDataCommandValidator : AbstractCommandValidator<ReseedDataCommand>
    {
        public ReseedDataCommandValidator()
        {
            
        }
    }

    public class ReseedDataCommandHandler : ICommandHandler<ReseedDataCommand>
    {
        private readonly CctDbContext _db;
        private readonly SeedDataHelper _seedDataHelper;

        public ReseedDataCommandHandler(CctDbContext db)
        {
            _db = db;
            _seedDataHelper = new SeedDataHelper(db);
        }

        public async Task ExecuteAsync(ReseedDataCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            await TruncateTables();
            await _seedDataHelper.Run();
        }

        private async Task TruncateTables()
        {
            await Truncate<CompetencyRatingGroup>();
            await Truncate<CompetencyTypeGroup>();
            await Truncate<JobGroupPosition>();
            await Truncate<JobPositionCompetency>();
            await Truncate<JobRolePositionCertificate>();
            await Truncate<JobRolePositionCompetency>();
            await Truncate<JobRolePositionCompetencyRating>();
            await Truncate<JobRolePositionHLCategory>();
            await Truncate<JobRolePositionLocation>();
            await Truncate<JobRole>();


            await Truncate<Competency>();
            await Truncate<CompetencyType>();
            await Truncate<Certificate>();

            await Truncate<JobLocationRegion>();
            await Truncate<JobPosition>();
            await Truncate<JobHLCategory>();
            await Truncate<JobGroupLevel>();
            await Truncate<JobGroup>();
            await Truncate<CompetencyLevelRequirement>();
            await Truncate<CompetencyRatingLevel>();

        }

        private async Task Truncate<T>() where T : class
        {
            var tableName = _db.Model.FindEntityType(typeof(T)).GetTableName();
            await _db.Database.ExecuteSqlRawAsync($"delete from [{tableName}]");
        }
    }
}
