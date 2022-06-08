using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class JobLocationRegion
    {
        public int Id { get; set; }

        [Display(Name = "English Name")]
        public string NameEng { get; set; } // ex : Atlantic, Western

        [Display(Name = "French Name")]
        public string NameFre { get; set; }

        public int Active { get; set; }  // ex : 0 = Location deleted, 1 = Location active

        public virtual ICollection<JobRolePositionLocation> JobRolePositionLocations { get; set; }
    }
}
