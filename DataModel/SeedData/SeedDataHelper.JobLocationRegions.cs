using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<JobLocationRegion> JobLocationRegions = new List<JobLocationRegion>()
        {
            new JobLocationRegion {Id = 1, NameEng = "Atlantic", NameFre = "Atlantique", Active = 1 },
            new JobLocationRegion {Id = 2, NameEng = "Western", NameFre = "Ouest", Active = 1 },
            new JobLocationRegion {Id = 3, NameEng = "Arctic", NameFre = "Arctique", Active = 1 },
            new JobLocationRegion {Id = 4, NameEng = "National Headquarters", NameFre = "Siège national", Active = 1 },
            new JobLocationRegion {Id = 5, NameEng = "Central", NameFre = "Centre", Active = 1 },
            new JobLocationRegion {Id = 6, NameEng = "CCG College", NameFre = "Collège de la GCC", Active = 1 },
        };
    }
}