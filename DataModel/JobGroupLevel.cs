using System;
using System.Collections.Generic;
using System.Text;


namespace DataModel
{
    public class JobGroupLevel
    {

        public int Id { get; set; }

        public string Value { get; set; }

        public virtual ICollection<JobRole> JobRoles { get; set; }

        public virtual ICollection<JobGroupPosition> JobGroupPositions { get; set; }

        public virtual ICollection<JobRolePositionCompetency> JobRolesPositionCompetencies { get; set; }


    }
}
