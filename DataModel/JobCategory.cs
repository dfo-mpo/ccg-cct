using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class JobCategory
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string ValueEng { get; set; } // offshore, onshore locations

        [StringLength(150)]
        public string ValueFre { get; set; }

        // entity will hold all of the JobGroupPosition entities that are related to that JobCategory entity.
        public virtual ICollection<JobGroupPosition> JobGroupPosition { get; set; }
    }

}
