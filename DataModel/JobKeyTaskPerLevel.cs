using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class JobKeyTaskPerLevel
    {
        public int JobKeyTaskPerLevelId { get; set; }

        public string JobKeyTaskPerLevelEng { get; set; }

        public string JobKeyTaskPerLevelFra { get; set; }

        // entity will hold all of the JobGroupPosition entities that are related to that JobKeyTaskPerLevel entity.
        public virtual ICollection<JobGroupPosition> JobGroupPosition { get; set; }
    }
}
