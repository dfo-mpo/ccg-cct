using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class CompetencyDetailLevelRequirements
    {
        public int CompetencyDetailLevelRequirementsId { get; set; }

        public string CompetencyDetailLevelRequirementsEng { get; set; }

        public string CompetencyDetailLevelRequirementsFra { get; set; }

        public virtual ICollection<CompetencyLevelRequirements> CompetencyLevelRequirements { get; set; }
    }
}
