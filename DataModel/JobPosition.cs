using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static DataModel.CustomValidation;

namespace DataModel
{
    public class JobPosition
    {
        public int Id { get; set; }

        [Display(Name = "Title English")]
        [MaxLength(3000)]
        [Required(ErrorMessage = "The position title is required")]
        public string TitleEng { get; set; } // ex: Manager, IT advisor

        [Display(Name = "Title French")]
        [MaxLength(3000)]
        [Required(ErrorMessage = "The position title is required")]
        public string TitleFre { get; set; }

        [Display(Name = "Position Description English")]
        [MaxLength(8000)]
        [BothOrNone("PositionDescFre", "Both descriptions must be provided if one is filled out")]
        public string PositionDescEng { get; set; } // ex: Manage an engine room crew

        [Display(Name = "Position Description French")]
        [MaxLength(8000)]
        public string PositionDescFre { get; set; }

        public int Active { get; set; } // ex : 0 = Position deleted, 1 = Position active

        public virtual ICollection<JobRolePositionCertificate> JobRolePositionCertificates { get; set; }

        public virtual ICollection<JobPositionCompetency> JobPositionCompetencies { get; set; }

        public virtual ICollection<JobRolePositionCompetency> JobRolePositionCompetencies { get; set; }
    }
}
