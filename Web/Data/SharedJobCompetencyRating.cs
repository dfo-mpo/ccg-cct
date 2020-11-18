using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Data
{
    public class SharedJobCompetencyRating
    {
        public int TypeId { get; set; }
            public string TypeNameEng { get; set; } // ex. Behavioral, knowledge, technical
            public string TypeNameFre { get; set; }

            public string CompetencyNameEng { get; set; }

            public string CompetencyNameFre { get; set; }

            public string CompetencyDescEng { get; set; }

            public string CompetencyDescFre { get; set; }
            //public int RatingId { get; set; }

            public int RatingValueCur { get; set; } // ex: 1, 2
            public int RatingValueObj { get; set; } // ex: 1, 2



    }
}
