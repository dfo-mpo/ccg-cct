using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class CompetencyLevelRequirements
    {
        public int CompetencyLevelRequirementsId { get; set; }

        public string CompetencyLevelRequirementsEng { get; set; }

        public string CompetencyLevelRequirementsFra { get; set; }

        // entity will hold all of the CompetencyGroupsRatings entities that are related to that CompetencyLevelRequirements entity.
        public virtual ICollection<CompetencyGroupsRatings> CompetencyGroupsRatings { get; set; }
    }
}
