using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel
{
    public class JobKeyTaskPerLevel
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string KeyTaskPerLevelEng { get; set; }

        [StringLength(150)]
        public string KeyTaskPerLevelFre { get; set; }

        // entity will hold all of the JobGroupPosition entities that are related to that JobKeyTaskPerLevel entity.
        public virtual ICollection<JobGroupPosition> JobGroupPosition { get; set; }
    }
}
