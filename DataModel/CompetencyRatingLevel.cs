using System;
using System.Collections.Generic;
using System.Text;


namespace DataModel
{
    public class CompetencyRatingLevel
    {
        public int Id { get; set; }

        public int Value { get; set; } // ex: 1, 2

        public string NameEng { get; set; } // ex: Novice, Intermediate

        public string NameFre { get; set; }

        public string DescEng { get; set; }

        public string DescFre { get; set; }

        public virtual ICollection<JobRolePositionCompetencyRating> JobRolePositionCompetencyRatings { get; set; }

    }
}
