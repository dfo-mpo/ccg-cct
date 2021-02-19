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

            // link tables
            await AddIfEmpty(JobLocationRegions);
            await AddIfEmpty(JobRoles);
            await AddIfEmpty(JobGroupPositions);
            await AddIfEmpty(CompetencyTypeGroups);
            await AddIfEmpty(CompetencyRatingGroups);
            await AddIfEmpty(JobPositionCompetencies);
            await AddIfEmpty(JobRolePositionCompetencies);
            await AddIfEmpty(JobRolePositionCertificates);
            await AddIfEmpty(JobRolePositionCompetencyRatings);
            await AddIfEmpty(JobRolePositionLocations);
            await AddIfEmpty(JobRolePositionHLCategories);

        }

        private async Task AddIfEmpty<TModel>(List<TModel> models) where TModel : class
        {
            if (await _db.Set<TModel>().AnyAsync()) return;
            var strategy = _db.Database.CreateExecutionStrategy();
            await strategy.ExecuteAsync(async () =>
            {
                await using var transaction = await _db.Database.BeginTransactionAsync();
                await _db.Set<TModel>().AddRangeAsync(models);
                await Save<TModel>();
                await transaction.CommitAsync();
            });
        }


        private async Task Save<T>() where T : class
        {
            var tableName = _db.Model.FindEntityType(typeof(T)).GetTableName();
            try
            {
                await _db.Database.ExecuteSqlRawAsync($"SET IDENTITY_INSERT {tableName} ON;");
                await _db.SaveChangesAsync();
            }
            finally
            {
                await _db.Database.ExecuteSqlRawAsync($"SET IDENTITY_INSERT {tableName} OFF;");
            }

        }
    }
}