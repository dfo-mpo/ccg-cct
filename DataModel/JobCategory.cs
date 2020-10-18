using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class JobCategory
    {
        public int JobCategoryId { get; set; }

        public string JobCategoryValueEng { get; set; }

        public string JobCategoryValueFra { get; set; }

        // entity will hold all of the JobGroupPosition entities that are related to that JobCategory entity.
        public virtual ICollection<JobGroupPosition> JobGroupPosition { get; set; }
    }

}
