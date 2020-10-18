using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    //  Competency Type other than Certificate: KE, TE and BE
    public class CompetencyCategory : CompetencyType
    {
        // Level of competencies ( 1 to 5) only for KE, TE and BE
        public virtual ICollection<CompetencyRatings> CompetencyRatings { get; set; }
    }
}
