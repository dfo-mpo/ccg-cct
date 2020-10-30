using System;
using System.Collections.Generic;
using System.Text;



namespace DataModel
{
    public class JobLocationRegion
    {
        public int Id { get; set; }

        public string NameEng { get; set; }

        public string NameFre { get; set; }

        public virtual ICollection<JobGroupPosition> JobGroupPositions { get; set; }
    }
}
