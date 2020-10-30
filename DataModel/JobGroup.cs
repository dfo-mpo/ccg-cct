using System;
using System.Collections.Generic;
using System.Text;


namespace DataModel
{
    public class JobGroup
    {     
        public int Id { get; set; }

        public string ClassificationName { get; set; }

        public virtual ICollection<JobRole> JobRoles { get; set; }

        public virtual ICollection<JobGroupPosition> JobGroupPositions { get; set; }

        public virtual ICollection<JobRolePositionCompetency> JobRolesPositionCompetencies { get; set; }

    }
}
