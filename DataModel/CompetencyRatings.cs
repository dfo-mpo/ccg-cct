using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    // map between Type and Ratings Level (1 to 5)
    public class CompetencyRatings
    {
        public int CompetencyTypeId { get; set; }

        public CompetencyType CompetencyType { get; set; }

        public int CompetencyRatingLevelId { get; set; }

        public CompetencyRatingLevel CompetencyRatingLevel { get; set; }
    }
}
