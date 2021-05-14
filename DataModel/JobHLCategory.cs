using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class JobHLCategory
    {
        public int Id { get; set; }

        public string ValueEng { get; set; } // ex:  Seagoing, Shoreside 

        public string ValueFre { get; set; }

        public int Active { get; set; }  // ex : 0 = HLCategory deleted, 1 = HLCategory active
        public virtual ICollection<JobRolePositionHLCategory> JobRolePositionHLCategory { get; set; }
    }

}
