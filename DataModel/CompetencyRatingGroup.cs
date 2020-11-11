using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class CompetencyRatingGroup
    {
        public int CompetencyId { get; set; }

        public Competency Competency { get; set; }

        public int CompetencyRatingLevelId { get; set; }

        public CompetencyRatingLevel CompetencyRatingLevel { get; set; }
 
        public int CompetencyLevelRequirementId { get; set; }

        public CompetencyLevelRequirement CompetencyLevelRequirement { get; set; }
    }
}
