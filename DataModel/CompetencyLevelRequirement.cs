using System;
using System.Collections.Generic;
using System.Text;


namespace DataModel
{
    public class CompetencyLevelRequirement
    {
        public int Id { get; set; }

        public string DescEng { get; set; }

        public string DescFre { get; set; }

        public virtual ICollection<JobRolePositionCompetencyRating> JobRolePositionCompetencyRatings { get; set; }
    }
}
