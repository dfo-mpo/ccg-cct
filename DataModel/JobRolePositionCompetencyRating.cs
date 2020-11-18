using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class JobRolePositionCompetencyRating
    {
        public int JobGroupId { get; set; }

        public JobGroup JobGroup { get; set; }

        public int JobGroupLevelId { get; set; }

        public JobGroupLevel JobGroupLevel { get; set; }

        public int JobPositionId { get; set; }

        public JobPosition JobPosition { get; set; }

        public int CompetencyId { get; set; }

        public Competency Competency { get; set; }

        public int CompetencyTypeId { get; set; }

        public CompetencyType CompetencyType { get; set; }

        public int CompetencyRatingLevelId { get; set; }

        public CompetencyRatingLevel CompetencyRatingLevel { get; set; }
 
        public int CompetencyLevelReqId { get; set; }

        public CompetencyLevelRequirement CompetencyLevelRequirement { get; set; }
    }
}
