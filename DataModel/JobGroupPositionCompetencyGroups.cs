using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class JobGroupPositionCompetencyGroups
    {
        public int JobGroupPositionId { get; set; }
        public JobGroupPosition JobGroupPosition { get; set; }

        public int CompetencyId { get; set; }

        public Competency Competency { get; set; }

        public int CompetencyTypeid { get; set; }

        public CompetencyType CompetencyType { get; set; }
    }
}
