using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class CompetencyRatingLevel
    {
        public int Id { get; set; }

        public int Value { get; set; } // ex: 1, 2

        [Display(Name = "Name English")]
        public string NameEng { get; set; } // ex: Novice, Intermediate

        [Display(Name = "Name French")]
        public string NameFre { get; set; }

        [Display(Name = "Description English")]
        public string DescEng { get; set; }

        [Display(Name = "Description French")]
        public string DescFre { get; set; }

        public virtual ICollection<JobRolePositionCompetencyRating> JobRolePositionCompetencyRatings { get; set; }

    }
}
