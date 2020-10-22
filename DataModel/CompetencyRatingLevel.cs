using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class CompetencyRatingLevel
    {
        public int CompetencyRatingLevelId { get; set; }

        public string CompetencyRatingLevelNameEng { get; set; }

        public string CompetencyRatingLevelNameFra { get; set; }

        public string CompetencyRatingLevelDescriptionEng { get; set; }

        public string CompetencyRatingLevelDescriptionFra { get; set; }

        // entity will hold all of the CompetencyGroupsRatings entities that are related to that CompetencyRatingLevel entity.
        public virtual ICollection<CompetencyGroupsRatings> CompetencyGroupsRatings { get; set; }

    }
}