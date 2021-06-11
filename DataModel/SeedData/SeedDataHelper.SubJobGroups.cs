using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<SubJobGroup> SubJobGroups = new List<SubJobGroup>()
        {
            new SubJobGroup() {Id = 1, SubCode = "MOC", Active = 1 },
            new SubJobGroup() {Id = 2, SubCode = "WOW", Active = 1 },
            new SubJobGroup() {Id = 3, SubCode = "VHE", Active = 1 },
            new SubJobGroup() {Id = 4, SubCode = "PCF", Active = 1 },
            new SubJobGroup() {Id = 5, SubCode = "SPT", Active = 1 },
            new SubJobGroup() {Id = 6, SubCode = "STD", Active = 1 },
            new SubJobGroup() {Id = 7, SubCode = "DED", Active = 1 },
            new SubJobGroup() {Id = 8, SubCode = "ERD", Active = 1 },
            new SubJobGroup() {Id = 9, SubCode = "MAO", Active = 1 },
            new SubJobGroup() {Id = 10, SubCode = "INS", Active = 1 },
            new SubJobGroup() {Id = 11, SubCode = "FOS", Active = 1 },
            new SubJobGroup() {Id = 12, SubCode = "STS", Active = 1 },
            new SubJobGroup() {Id = 13, SubCode = "EDS", Active = 1 },
            new SubJobGroup() {Id = 14, SubCode = "LAT", Active = 1 },
            new SubJobGroup() {Id = 15, SubCode = "EST", Active = 1 },
            new SubJobGroup() {Id = 16, SubCode = "MAN", Active = 1 },
            new SubJobGroup() {Id = 17, SubCode = "COI", Active = 1 },
            new SubJobGroup() {Id = 18, SubCode = "MDO", Active = 1 },
            new SubJobGroup() {Id = 19, SubCode = "PRW", Active = 1 },
            new SubJobGroup() {Id = 20, SubCode = "EIM", Active = 1 },
            new SubJobGroup() {Id = 21, SubCode = "MAM", Active = 1 },
            new SubJobGroup() {Id = 22, SubCode = "CR", Active = 1 },
            new SubJobGroup() {Id = 23, SubCode = "DM", Active = 1 },
            new SubJobGroup() {Id = 24, SubCode = "DEO", Active = 1 },
            new SubJobGroup() {Id = 25, SubCode = "", Active = 1 },
            new SubJobGroup() {Id = 26, SubCode = "PEI", Active = 1 },
            new SubJobGroup() {Id = 27, SubCode = "CHN", Active = 1 }
         };
    }
}