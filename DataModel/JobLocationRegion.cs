using System;
using System.Collections.Generic;
using System.Text;



namespace DataModel
{
    public class JobLocationRegion
    {
        public int Id { get; set; }

        public string NameEng { get; set; } // ex : Atlantic, Western

        public string NameFre { get; set; }

        public int Active { get; set; } 

        public virtual ICollection<JobRolePositionLocation> JobRolePositionLocations { get; set; }
    }
}
