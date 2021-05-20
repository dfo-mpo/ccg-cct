using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<SubJobGroup> SubJobGroups = new List<SubJobGroup>()
        {
            new SubJobGroup() {Id = 1, SubCode = "MOC"},
            new SubJobGroup() {Id = 2, SubCode = "WOW"},
            new SubJobGroup() {Id = 3, SubCode = "VHE"},
            new SubJobGroup() {Id = 4, SubCode = "PCF"},
            new SubJobGroup() {Id = 5, SubCode = "SPT"},
            new SubJobGroup() {Id = 6, SubCode = "STD"},
            new SubJobGroup() {Id = 7, SubCode = "DED"},
            new SubJobGroup() {Id = 8, SubCode = "ERD"},
            new SubJobGroup() {Id = 9, SubCode = "MAO"},
            new SubJobGroup() {Id = 10, SubCode = "INS"},
            new SubJobGroup() {Id = 11, SubCode = "FOS"},
            new SubJobGroup() {Id = 12, SubCode = "STS"},
            new SubJobGroup() {Id = 13, SubCode = "EDS"},
            new SubJobGroup() {Id = 14, SubCode = "LAT"},
            new SubJobGroup() {Id = 15, SubCode = "EST"},
            new SubJobGroup() {Id = 16, SubCode = "MAN"},
            new SubJobGroup() {Id = 17, SubCode = "COI"},
            new SubJobGroup() {Id = 18, SubCode = "MDO"},
            new SubJobGroup() {Id = 19, SubCode = "PRW"},
            new SubJobGroup() {Id = 20, SubCode = "EIM"},
            new SubJobGroup() {Id = 21, SubCode = "MAM"},
            new SubJobGroup() {Id = 22, SubCode = "CR"},
            new SubJobGroup() {Id = 23, SubCode = "DM"},
            new SubJobGroup() {Id = 24, SubCode = "DEO"},
            new SubJobGroup() {Id = 25, SubCode = ""},
            new SubJobGroup() {Id = 26, SubCode = "PEI"}
         };
    }
}
