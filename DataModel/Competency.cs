using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class Competency
    {

        public int Id { get; set; }

        [Display(Name = "Name English")]
        [Required]
        public string NameEng { get; set; }

        [Display(Name = "Name French")]
        [Required]
        public string NameFre { get; set; }

        [Display(Name = "Description English")]
        [Required]
        public string DescEng { get; set; }

        [Display(Name = "Description French")]
        [Required]
        public string DescFre { get; set; }

        public int Active { get; set; } // ex : 0 = competency deleted, 1 = competency active

        public virtual ICollection<JobRolePositionCompetencyRating> JobRolePositionCompetencyRatings { get; set; }

        public virtual ICollection<CompetencyTypeGroup> CompetencyTypeGroups { get; set; }

        public virtual ICollection<JobPositionCompetency> JobPositionCompetencies { get; set; }

        public virtual ICollection<JobRolePositionCompetency> JobRolePositionCompetencies { get; set; }

    }
}
