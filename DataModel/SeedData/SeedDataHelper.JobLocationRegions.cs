using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<JobLocationRegion> JobLocationRegions = new List<JobLocationRegion>()
        {
            new JobLocationRegion {Id = 1, NameEng = "Atlantic", NameFre = "Atlantique"},
            new JobLocationRegion {Id = 2, NameEng = "Western", NameFre = "Ouest"},
            new JobLocationRegion {Id = 3, NameEng = "Arctic", NameFre = "Arctique"},
            new JobLocationRegion {Id = 4, NameEng = "National Headquarters", NameFre = "Siège national"},
            new JobLocationRegion {Id = 5, NameEng = "Central and Arctic", NameFre = "Centre et Arctique"},
            new JobLocationRegion {Id = 6, NameEng = "CCG College", NameFre = "Collège de la GCC"},
            new JobLocationRegion {Id = 7, NameEng = "All Regions", NameFre = "Toutes les régions"}
        };
    }
}