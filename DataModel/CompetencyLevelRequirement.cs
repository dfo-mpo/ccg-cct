using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class CompetencyLevelRequirement
    {
        public int Id { get; set; }

        [Display(Name = "Description English")]
        public string DescEng { get; set; }

        [Display(Name = "Description French")]
        public string DescFre { get; set; }

        public virtual ICollection<JobRolePositionCompetencyRating> JobRolePositionCompetencyRatings { get; set; }
    }
}
