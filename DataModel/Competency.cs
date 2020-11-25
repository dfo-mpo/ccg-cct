using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel
{
    public class Competency
    {
        
        public int Id { get; set; }

        public string NameEng { get; set; }

        public string NameFre { get; set; }

        public string DescEng { get; set; }

        public string DescFre { get; set; }

        public virtual ICollection<JobRolePositionCompetencyRating> JobPositionCompetencyRatings { get; set; }

        public virtual ICollection<CompetencyTypeGroup> CompetencyTypeGroups { get; set; }
        
        public virtual ICollection<JobPositionCompetency> JobPositionCompetencies { get; set; }
        

    }
}
