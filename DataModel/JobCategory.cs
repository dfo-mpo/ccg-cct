using System;
using System.Collections.Generic;
using System.Text;


namespace DataModel
{
    public class JobCategory
    {
        public int Id { get; set; }

        public string ValueEng { get; set; } // ex:  Onboard, onshore 

        public string ValueFre { get; set; }

        public virtual ICollection<JobGroupPosition> JobGroupPositions { get; set; }
    }

}
