using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class JobGroupLevel
    {

        // Primary Key
        public int JobGroupLevelId { get; set; }

        // Properties
        public string JobGroupClassificationLevel { get; set; }

        // entity will hold all of the JobRoles entities that are related to that JobGroupLevel entity.
        public virtual ICollection<JobRoles> JobRoles { get; set; }

        // entity will hold all of the JobGroupPosition entities that are related to that JobGroupLevel entity.
        public virtual ICollection<JobGroupPosition> JobGroupPosition { get; set; }

        // entity will hold all of the JobRolesPositionCompetency entities that are related to that JobGroupLevel entity.
        public virtual ICollection<JobRolesPositionCompetency> JobRolesPositionCompetency { get; set; }


    }
}
