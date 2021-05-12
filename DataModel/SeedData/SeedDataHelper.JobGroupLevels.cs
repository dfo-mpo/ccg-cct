using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
 
namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<JobGroupLevel> JobGroupLevels = new List<JobGroupLevel>()
        {
            new JobGroupLevel() {Id = 1, LevelValue = 01},
            new JobGroupLevel() {Id = 2, LevelValue = 02},
            new JobGroupLevel() {Id = 3, LevelValue = 03},
            new JobGroupLevel() {Id = 4, LevelValue = 04},
            new JobGroupLevel() {Id = 5, LevelValue = 05},
            new JobGroupLevel() {Id = 6, LevelValue = 06},
            new JobGroupLevel() {Id = 7, LevelValue = 07},
            new JobGroupLevel() {Id = 8, LevelValue = 08},
            new JobGroupLevel() {Id = 9, LevelValue = 09},
            new JobGroupLevel() {Id = 10, LevelValue = 10},
            new JobGroupLevel() {Id = 11, LevelValue = 11}
            
        };
    }
}