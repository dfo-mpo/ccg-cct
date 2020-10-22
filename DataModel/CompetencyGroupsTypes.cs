
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class CompetencyGroupsTypes
    {
        public int CompetencyId { get; set; }

        public Competency Competency { get; set; }

        public int CompetencyTypeid { get; set; }

        public CompetencyType CompetencyType { get; set; }
    }
}
