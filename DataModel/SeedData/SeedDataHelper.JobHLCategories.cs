using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<JobHLCategory> JobHLCategories = new List<JobHLCategory>()
        {
            new JobHLCategory() {Id = 1, ValueEng = "Seagoing", ValueFre = "En mer"},
            new JobHLCategory() {Id = 2, ValueEng = "Shoreside", ValueFre = "Sur terre"}
        };

    }
}