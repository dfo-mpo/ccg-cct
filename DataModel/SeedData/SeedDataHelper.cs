﻿using System;
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
            await ExecuteWithStrategy(JobGroups());
            await ExecuteWithStrategy(JobGroupLevels());
            await ExecuteWithStrategy(JobPositions());
            await ExecuteWithStrategy(JobHLCategories());
            await ExecuteWithStrategy(Competencies());
            await ExecuteWithStrategy(CompetencyRatingLevel());
            await ExecuteWithStrategy(CompetencyTypes());
            await ExecuteWithStrategy(CompetencyLevelRequirements());
            await ExecuteWithStrategy(Certificates());

            // link tables
            await ExecuteWithStrategy(JobLocationRegions());
            await ExecuteWithStrategy(JobRoles());
            await ExecuteWithStrategy(JobGroupPositions());
            await ExecuteWithStrategy(CompetencyTypeGroups());
            await ExecuteWithStrategy(CompetencyRatingGroups());
            await ExecuteWithStrategy(JobPositionCompetencies());
            await ExecuteWithStrategy(JobRolePositionCompetencies());
            await ExecuteWithStrategy(JobRolePositionCertificates());
            await ExecuteWithStrategy(JobRolePositionCompetencyRatings());
            await ExecuteWithStrategy(JobRolePositionLocations());
            await ExecuteWithStrategy(JobRolePositionHLCategories());

        }

        private async Task ExecuteWithStrategy(Task transaction)
        {
            var strategy = _db.Database.CreateExecutionStrategy();
            await strategy.ExecuteAsync(async() =>
            {
                await transaction;
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