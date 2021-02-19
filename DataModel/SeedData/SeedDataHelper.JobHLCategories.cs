using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        private async Task JobHLCategories()
        {
            if (await _db.JobHLCategories.AnyAsync()) return;

            using var transaction = await _db.Database.BeginTransactionAsync();
            await _db.JobHLCategories.AddRangeAsync(new List<JobHLCategory>()
            {
                new JobHLCategory() {Id = 1, ValueEng = "Seagoing", ValueFre = "En mer"},
                new JobHLCategory() {Id = 2, ValueEng = "Shoreside", ValueFre = "Sur terre"}
            });
            await Save<JobHLCategory>();
            await transaction.CommitAsync();
        }
    }
}