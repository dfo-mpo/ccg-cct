using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        private readonly CctDbContext _db;

        public SeedDataHelper(CctDbContext db)
        {
            _db = db;
        }

        public async Task Run()
        {
            // base tables
            
            await AddIfEmpty(JobGroups);
            await AddIfEmpty(JobGroupLevels);
            await AddIfEmpty(JobPositions);
            await AddIfEmpty(JobHLCategories);
            await AddIfEmpty(Competencies);
            await AddIfEmpty(CompetencyRatingLevel);
            await AddIfEmpty(CompetencyTypes);
            await AddIfEmpty(CompetencyLevelRequirements);
            await AddIfEmpty(Certificates);
            await AddIfEmpty(CertificateDescriptions);
            await AddIfEmpty(JobLocationRegions);
            await AddIfEmpty(SubJobGroups);

            // link tables

            await AddIfEmpty(JobRoles, false);
            await AddIfEmpty(JobGroupPositions, false);
            await AddIfEmpty(CompetencyTypeGroups, false);
            await AddIfEmpty(CompetencyRatingGroups, false);
            await AddIfEmpty(JobPositionCompetencies, false);
            await AddIfEmpty(JobRolePositionCompetencies, false);
            await AddIfEmpty(JobRolePositionCertificates, false);
            await AddIfEmpty(JobRolePositionCompetencyRatings, false);
            await AddIfEmpty(JobRolePositionLocations, false);
            await AddIfEmpty(JobRolePositionHLCategories, false);
            


        }

        private async Task AddIfEmpty<TModel>(List<TModel> models, bool hasIdentityKey = true) where TModel : class
        {
            if (await _db.Set<TModel>().AnyAsync()) return;
            var strategy = _db.Database.CreateExecutionStrategy();
            await strategy.ExecuteAsync(async () =>
            {
                await using var transaction = await _db.Database.BeginTransactionAsync();
                await _db.Set<TModel>().AddRangeAsync(models);
                await Save<TModel>(hasIdentityKey);
                await transaction.CommitAsync();
            });
        }


        private async Task Save<T>(bool hasIdentityKey) where T : class
        {
            var tableName = _db.Model.FindEntityType(typeof(T)).GetTableName();
            try
            {
                if (hasIdentityKey)
                {
                    await _db.Database.ExecuteSqlRawAsync($"SET IDENTITY_INSERT {tableName} ON;");
                }
                await _db.SaveChangesAsync();
            }
            finally
            {
                if (hasIdentityKey)
                {

                    await _db.Database.ExecuteSqlRawAsync($"SET IDENTITY_INSERT {tableName} OFF;");
                }
            }

        }
    }
}