using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<CompetencyType> CompetencyTypes = new List<CompetencyType>()
        {
            new CompetencyType() {Id = 1, NameEng = "Knowledge Elements", NameFre = "Éléments de connaissance"},
            new CompetencyType() {Id = 2, NameEng = "Technical Elements", NameFre = "Éléments techniques"},
            new CompetencyType() {Id = 3, NameEng = "Behavioural Elements", NameFre = "Éléments de comportement"}
        };
    }
}