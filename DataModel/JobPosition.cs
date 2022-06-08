using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class JobPosition
    {
        public int Id { get; set; }

        [Display(Name = "Title English")]
        public string TitleEng { get; set; } // ex: Manager, IT advisor

        [Display(Name = "Title French")]
        public string TitleFre { get; set; }

        [Display(Name = "Position Description English")]
        public string PositionDescEng { get; set; } // ex: Manage an engine room crew

        [Display(Name = "Position Description French")]
        public string PositionDescFre { get; set; }

        public int Active { get; set; } // ex : 0 = Position deleted, 1 = Position active

        public virtual ICollection<JobRolePositionCertificate> JobRolePositionCertificates { get; set; }

        public virtual ICollection<JobPositionCompetency> JobPositionCompetencies { get; set; }

        public virtual ICollection<JobRolePositionCompetency> JobRolePositionCompetencies { get; set; }
    }
}
