using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel
{
    public class CompetencyRatingLevel
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string RatingLevelNameEng { get; set; }

        [StringLength(150)]
        public string RatingLevelNameFre { get; set; }

        [StringLength(150)]
        public string RatingLevelDescEng { get; set; }

        [StringLength(150)]
        public string RatingLevelDescFre { get; set; }

        // entity will hold all of the CompetencyGroupsRatings entities that are related to that CompetencyRatingLevel entity.
        public virtual ICollection<CompetencyGroupsRating> CompetencyGroupsRating { get; set; }

    }
}
