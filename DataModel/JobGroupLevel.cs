using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class JobGroupLevel
    {

        // Primary Key
        public int Id { get; set; }

        // Properties

        [StringLength(150)]
        public string ClassificationLevel { get; set; }

        // entity will hold all of the JobRoles entities that are related to that JobGroupLevel entity.
        public virtual ICollection<JobRole> JobRole { get; set; }

        // entity will hold all of the JobGroupPosition entities that are related to that JobGroupLevel entity.
        public virtual ICollection<JobGroupPosition> JobGroupPosition { get; set; }

        // entity will hold all of the JobRolesPositionCompetency entities that are related to that JobGroupLevel entity.
        public virtual ICollection<JobRolesPositionCompetency> JobRolesPositionCompetency { get; set; }


    }
}
