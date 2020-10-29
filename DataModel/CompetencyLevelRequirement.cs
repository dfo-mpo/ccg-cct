using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel
{
    public class CompetencyLevelRequirement
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string RequirementsDescEng { get; set; }

        [StringLength(150)]
        public string RequirementsDescFre { get; set; }

        // entity will hold all of the CompetencyGroupsRatings entities that are related to that CompetencyLevelRequirements entity.
        public virtual ICollection<CompetencyGroupsRating> CompetencyGroupsRating { get; set; }
    }
}
