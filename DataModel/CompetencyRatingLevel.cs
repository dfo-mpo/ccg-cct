using System;
using System.Collections.Generic;
using System.Text;


namespace DataModel
{
    public class CompetencyRatingLevel
    {
        public int Id { get; set; }

        public string NameEng { get; set; }

        public string NameFre { get; set; }

        public string DescEng { get; set; }

        public string DescFre { get; set; }

        public virtual ICollection<CompetencyRatingGroup> CompetencyRatingGroups { get; set; }

    }
}
