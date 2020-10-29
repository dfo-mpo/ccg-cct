using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel
{
    public class JobLocationRegion
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string RegionNameEng { get; set; }

        [StringLength(150)]
        public string RegionNameFre { get; set; }

        // entity will hold all of the JobGroupPosition entities that are related to that JobLocationRegion entity.
        public virtual ICollection<JobGroupPosition> JobGroupPosition { get; set; }
    }
}
