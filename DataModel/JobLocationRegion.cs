using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class JobLocationRegion
    {
        public int JobLocationRegionId { get; set; }

        public string JobLocationRegionEng { get; set; }

        public string JobLocationRegionFra { get; set; }

        // entity will hold all of the JobGroupPosition entities that are related to that JobLocationRegion entity.
        public virtual ICollection<JobGroupPosition> JobGroupPosition { get; set; }
    }
}
