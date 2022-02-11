using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<JobGroupLevel> JobGroupLevels = new List<JobGroupLevel>()
        {
            new JobGroupLevel() {Id = 1, LevelValue = "01", Active = 1 },
            new JobGroupLevel() {Id = 2, LevelValue = "02", Active = 1 },
            new JobGroupLevel() {Id = 3, LevelValue = "03", Active = 1 },
            new JobGroupLevel() {Id = 4, LevelValue = "04", Active = 1 },
            new JobGroupLevel() {Id = 5, LevelValue = "05", Active = 1 },
            new JobGroupLevel() {Id = 6, LevelValue = "06", Active = 1 },
            new JobGroupLevel() {Id = 7, LevelValue = "07", Active = 1 },
            new JobGroupLevel() {Id = 8, LevelValue = "08", Active = 1 },
            new JobGroupLevel() {Id = 9, LevelValue = "09", Active = 1 },
            new JobGroupLevel() {Id = 10, LevelValue = "10", Active = 1 },
            new JobGroupLevel() {Id = 11, LevelValue = "11", Active = 1 },
            new JobGroupLevel() {Id = 12, LevelValue = "12", Active = 1 },
            new JobGroupLevel() {Id = 13, LevelValue = "13", Active = 1 },
            new JobGroupLevel() {Id = 14, LevelValue = "14", Active = 1 },
            new JobGroupLevel() {Id = 15, LevelValue = "15", Active = 1 }
        };
    }
}
