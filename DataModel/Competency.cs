using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class Competency
    {
        public int CompetencyId { get; set; }

        public string CompetencyNameEng { get; set; }
        public string CompetencyNameFra { get; set; }

        // entity will hold all of the CompetencyGroupsRatings entities that are related to that Competency entity.
        public virtual ICollection<CompetencyGroupsRatings> CompetencyGroupsRatings { get; set; }

        // entity will hold all of the CompetencyGroupsTypes entities that are related to that Competency entity.
        public virtual ICollection<CompetencyGroupsTypes> CompetencyGroupsTypes { get; set; }
        
        // entity will hold all of the JobPositionCompetency entities that are related to that Competency entity.
        public virtual ICollection<JobPositionCompetency> JobPositionCompetency { get; set; }
        
        // entity will hold all of the JobRolesPositionCompetency entities that are related to that Competency entity.
        public virtual ICollection<JobRolesPositionCompetency> JobRolesPositionCompetency { get; set; }

    }
}
