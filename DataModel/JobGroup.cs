using System;
using System.Collections.Generic;
using System.Text;


namespace DataModel
{
    public class JobGroup
    {     
        public int Id { get; set; }
        public string AcrEng { get; set; }// ex: AS, CS, GL 
        public string AcrFre { get; set; }
        public string NameEng { get; set; } 
        public string NameFre { get; set; }
        public virtual ICollection<JobRole> JobRoles { get; set; }

        public virtual ICollection<JobGroupPosition> JobGroupPositions { get; set; }

        public virtual ICollection<JobRolePositionCompetency> JobRolesPositionCompetencies { get; set; }

    }
}
