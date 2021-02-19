using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        private async Task CompetencyTypes()
        {
            if (await _db.CompetencyTypes.AnyAsync()) return;

            using var transaction = await _db.Database.BeginTransactionAsync();
            await _db.CompetencyTypes.AddRangeAsync(new List<CompetencyType>()
            {
                new CompetencyType() {Id = 1, NameEng = "Knowledge Elements", NameFre = "Éléments de connaissance"},
                new CompetencyType() {Id = 2, NameEng = "Technical Elements", NameFre = "Éléments techniques"},
                new CompetencyType() {Id = 3, NameEng = "Behavioural Elements", NameFre = "Éléments de comportement"}
            });
            await Save<CompetencyType>();
            await transaction.CommitAsync();
        }
    }
}