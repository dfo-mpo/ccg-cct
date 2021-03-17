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
            DeleteTable<CompetencyRatingGroup>();
            DeleteTable<CompetencyTypeGroup>();
            DeleteTable<JobGroupPosition>();
            DeleteTable<JobPositionCompetency>();
            DeleteTable<JobRolePositionCertificate>();
            DeleteTable<JobRolePositionCompetency>();
            DeleteTable<JobRolePositionCompetencyRating>();
            DeleteTable<JobRolePositionHLCategory>();
            DeleteTable<JobRolePositionLocation>();
            DeleteTable<JobRole>();


            DeleteTable<Competency>();
            DeleteTable<CompetencyType>();
            DeleteTable<Certificate>();
            DeleteTable<CertificateDescription>();

            DeleteTable<JobLocationRegion>();
            DeleteTable<JobPosition>();
            DeleteTable<JobHLCategory>();
            DeleteTable<JobGroupLevel>();
            DeleteTable<JobGroup>();
            DeleteTable<CompetencyLevelRequirement>();
            DeleteTable<CompetencyRatingLevel>();

            await _db.SaveChangesAsync();

        }

        private void DeleteTable<T>() where T : class
        {
            _db.RemoveRange(_db.Set<T>());
        }
    }
}

