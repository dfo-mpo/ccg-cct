using System;
using System.Collections.Generic;
using System.Text;


namespace DataModel
{
    public class CompetencyTypeGroup
    {
        public int CompetencyId { get; set; }

        public Competency Competency { get; set; }

        public int CompetencyTypeId { get; set; }

        public CompetencyType CompetencyType { get; set; }
    }
}
