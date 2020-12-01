using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Xunit.Extensions.AssertExtensions;

namespace DataModel.Tests
{
    public class MigrationTests
    {

        [Fact]
        public async Task CanMigration()
        {
            var dbHelper = new DbHelper<CctDbContext>();
            await using var db = dbHelper.GetDbContext();
            await db.Database.MigrateAsync();
        }

        [Fact]
        public async Task CanCreate()
        {
            var dbHelper = new DbHelper<CctDbContext>();
            await using var db = dbHelper.GetDbContext();
            await db.Database.EnsureCreatedAsync();
        }
    }
}
