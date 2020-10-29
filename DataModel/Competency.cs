using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class Competency
    {
        
        public int Id { get; set; }

        [StringLength(150)]
        public string NameEng { get; set; }

        [StringLength(150)]
        public string NameFre { get; set; }

        // entity will hold all of the CompetencyGroupsRatings entities that are related to that Competency entity.
        public virtual ICollection<CompetencyGroupsRating> CompetencyGroupsRating { get; set; }

        // entity will hold all of the CompetencyGroupsTypes entities that are related to that Competency entity.
        public virtual ICollection<CompetencyGroupsType> CompetencyGroupsType { get; set; }
        
        // entity will hold all of the JobPositionCompetency entities that are related to that Competency entity.
        public virtual ICollection<JobPositionCompetency> JobPositionCompetency { get; set; }
        
        // entity will hold all of the JobRolesPositionCompetency entities that are related to that Competency entity.
        public virtual ICollection<JobRolesPositionCompetency> JobRolesPositionCompetency { get; set; }

    }
}
