using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace DataModel
{
    public class JobGroup
    {     
        public int Id { get; set; }

        public string Code { get; set; } // ex: AS, CS, GL
        
        public string NameEng { get; set; } // ex. Administrative services

        public string NameFre { get; set; } // ex. Services administratifs

        public virtual ICollection<JobRole> JobRoles { get; set; }

        public virtual ICollection<JobGroupPosition> JobGroupPositions { get; set; }

        public virtual ICollection<JobRolePositionCompetency> JobRolePositionCompetencies { get; set; }

    }
}
