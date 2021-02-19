using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        private async Task JobGroupLevels()
        {
            if (await _db.JobGroupLevels.AnyAsync()) return;

            using var transaction = await _db.Database.BeginTransactionAsync();
            await _db.JobGroupLevels.AddRangeAsync(new List<JobGroupLevel>()
            {
                new JobGroupLevel() {Id = 1, LevelValue = "01"},
                new JobGroupLevel() {Id = 2, LevelValue = "02"},
                new JobGroupLevel() {Id = 3, LevelValue = "03"},
                new JobGroupLevel() {Id = 4, LevelValue = "04"},
                new JobGroupLevel() {Id = 5, LevelValue = "05"},
                new JobGroupLevel() {Id = 6, LevelValue = "06"},
                new JobGroupLevel() {Id = 7, LevelValue = "07"},
                new JobGroupLevel() {Id = 8, LevelValue = "08"},
                new JobGroupLevel() {Id = 9, LevelValue = "09"},
                new JobGroupLevel() {Id = 10, LevelValue = "MOC-05"},
                new JobGroupLevel() {Id = 11, LevelValue = "MOC-07"},
                new JobGroupLevel() {Id = 12, LevelValue = "WOW-09"},
                new JobGroupLevel() {Id = 13, LevelValue = "WOW-10"},
                new JobGroupLevel() {Id = 14, LevelValue = "VHE-10"},
                new JobGroupLevel() {Id = 15, LevelValue = "PCF-06"},
                new JobGroupLevel() {Id = 16, LevelValue = "PCF-07"},
                new JobGroupLevel() {Id = 17, LevelValue = "PCF-08"},
                new JobGroupLevel() {Id = 18, LevelValue = "SPT-03"},
                new JobGroupLevel() {Id = 19, LevelValue = "SPT-04"},
                new JobGroupLevel() {Id = 20, LevelValue = "SPT-05"},
                new JobGroupLevel() {Id = 21, LevelValue = "STD-01"},
                new JobGroupLevel() {Id = 22, LevelValue = "STD-03"},
                new JobGroupLevel() {Id = 23, LevelValue = "STD-04"},
                new JobGroupLevel() {Id = 24, LevelValue = "STD-05"},
                new JobGroupLevel() {Id = 25, LevelValue = "DED-02"},
                new JobGroupLevel() {Id = 26, LevelValue = "DED-03"},
                new JobGroupLevel() {Id = 27, LevelValue = "DED-04"},
                new JobGroupLevel() {Id = 28, LevelValue = "DED-05"},
                new JobGroupLevel() {Id = 29, LevelValue = "DED-06"},
                new JobGroupLevel() {Id = 30, LevelValue = "DED-07"},
                new JobGroupLevel() {Id = 31, LevelValue = "ERD-03"},
                new JobGroupLevel() {Id = 32, LevelValue = "ERD-04"},
                new JobGroupLevel() {Id = 33, LevelValue = "ERD-05"},
                new JobGroupLevel() {Id = 34, LevelValue = "MAO-02"},
                new JobGroupLevel() {Id = 35, LevelValue = "MAO-03"},
                new JobGroupLevel() {Id = 36, LevelValue = "MAO-04"},
                new JobGroupLevel() {Id = 37, LevelValue = "MAO-05"},
                new JobGroupLevel() {Id = 38, LevelValue = "MAO-06"},
                new JobGroupLevel() {Id = 39, LevelValue = "MAO-07"},
                new JobGroupLevel() {Id = 40, LevelValue = "MAO-08"},
                new JobGroupLevel() {Id = 41, LevelValue = "MAO-09"},
                new JobGroupLevel() {Id = 42, LevelValue = "MAO-10"},
                new JobGroupLevel() {Id = 43, LevelValue = "MAO-11"},
                new JobGroupLevel() {Id = 44, LevelValue = "MAO-12"},
                new JobGroupLevel() {Id = 45, LevelValue = "MAO-13"},
                new JobGroupLevel() {Id = 46, LevelValue = "INS-01"},
                new JobGroupLevel() {Id = 47, LevelValue = "INS-02"},
                new JobGroupLevel() {Id = 48, LevelValue = "FOS-02"},
                new JobGroupLevel() {Id = 49, LevelValue = "FOS-05"},
                new JobGroupLevel() {Id = 50, LevelValue = "FOS-09"},
                new JobGroupLevel() {Id = 51, LevelValue = "STS-03"},
                new JobGroupLevel() {Id = 52, LevelValue = "STS-05"},
                new JobGroupLevel() {Id = 53, LevelValue = "EDS-01"},
                new JobGroupLevel() {Id = 54, LevelValue = "LAT-01"},
                new JobGroupLevel() {Id = 55, LevelValue = "EST-01"},
                new JobGroupLevel() {Id = 56, LevelValue = "EST-02"},
                new JobGroupLevel() {Id = 57, LevelValue = "MAN-05"},
                new JobGroupLevel() {Id = 58, LevelValue = "MAN-06"},
                new JobGroupLevel() {Id = 59, LevelValue = "MAN-07"},
                new JobGroupLevel() {Id = 60, LevelValue = "MAN-08"},
                new JobGroupLevel() {Id = 61, LevelValue = "MAN-09"},
                new JobGroupLevel() {Id = 62, LevelValue = "MAN-10"},
                new JobGroupLevel() {Id = 63, LevelValue = "COI-09"},
                new JobGroupLevel() {Id = 64, LevelValue = "COI-10"},
                new JobGroupLevel() {Id = 65, LevelValue = "COI-11"},
                new JobGroupLevel() {Id = 66, LevelValue = "MDO-03"},
                new JobGroupLevel() {Id = 67, LevelValue = "MDO-04"},
                new JobGroupLevel() {Id = 68, LevelValue = "MDO-05"},
                new JobGroupLevel() {Id = 69, LevelValue = "MDO-06"},
                new JobGroupLevel() {Id = 70, LevelValue = "MDO-07"},
                new JobGroupLevel() {Id = 71, LevelValue = "PRW-08"},
                new JobGroupLevel() {Id = 72, LevelValue = "PRW-09"},
                new JobGroupLevel() {Id = 73, LevelValue = "PRW-10"},
                new JobGroupLevel() {Id = 74, LevelValue = "PRW-11"},
                new JobGroupLevel() {Id = 75, LevelValue = "EIM-10"},
                new JobGroupLevel() {Id = 76, LevelValue = "EIM-11"},
                new JobGroupLevel() {Id = 77, LevelValue = "MAM-09"},
                new JobGroupLevel() {Id = 78, LevelValue = "MAM-10"},
                new JobGroupLevel() {Id = 79, LevelValue = "MAM-11"},
                new JobGroupLevel() {Id = 80, LevelValue = "CR-02"},
                new JobGroupLevel() {Id = 81, LevelValue = "CR-03"},
                new JobGroupLevel() {Id = 82, LevelValue = "CR-04"},
                new JobGroupLevel() {Id = 83, LevelValue = "CR-05"}
            });
            await Save<JobGroupLevel>();
            await transaction.CommitAsync();
        }
    }
}