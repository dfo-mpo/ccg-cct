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
            await DeleteTables();
            await _seedDataHelper.Run();
        }

        private async Task DeleteTables()
        {
            await DeleteTable<CompetencyRatingGroup>();
            await DeleteTable<CompetencyTypeGroup>();
            await DeleteTable<JobGroupPosition>();
            await DeleteTable<JobPositionCompetency>();
            await DeleteTable<JobRolePositionCertificate>();
            await DeleteTable<JobRolePositionCompetency>();
            await DeleteTable<JobRolePositionCompetencyRating>();
            await DeleteTable<JobRolePositionHLCategory>();
            await DeleteTable<JobRolePositionLocation>();
            await DeleteTable<JobRole>();


            await DeleteTable<Competency>();
            await DeleteTable<CompetencyType>();
            await DeleteTable<Certificate>();

            await DeleteTable<JobLocationRegion>();
            await DeleteTable<JobPosition>();
            await DeleteTable<JobHLCategory>();
            await DeleteTable<JobGroupLevel>();
            await DeleteTable<JobGroup>();
            await DeleteTable<CompetencyLevelRequirement>();
            await DeleteTable<CompetencyRatingLevel>();

        }

        private async Task DeleteTable<T>() where T : class
        {
            var tableName = _db.Model.FindEntityType(typeof(T)).GetTableName();
            await _db.Database.ExecuteSqlRawAsync($"delete from [{tableName}]");
        }
    }
}
