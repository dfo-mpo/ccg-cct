
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class CompetencyType
    {
        public int CompetencyTypeId { get; set; }

        public string CompetencyCategoryEng { get; set; } // Certificate, KE, TE, BE

        public string CompetencyCategoryFra { get; set; }

        // entity will hold all of the CompetencyGroupsTypes entities that are related to that CompetencyType entity.
        public virtual ICollection<CompetencyGroupsTypes> CompetencyGroupsTypes { get; set; }
    }
}
