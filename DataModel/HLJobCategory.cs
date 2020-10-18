using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel
{
    public class HLJobCategory
    {
        // primary key

        [Key]
        public Guid Id { get; set; }

        // Properties 

        [Column("HLjobCategoryValueEng")]
        public string HLjobCategoryValueEng { get; set; }

        [Column("HLjobCategoryValueFre")]
        public string HLjobCategoryValueFre { get; set; }

        // Relationships

        [NotMapped]
        public virtual ICollection<Competency> Competencies { get; set; }

        [NotMapped]
        public virtual ICollection<JobGroup> JobGroups { get; set; }
    }

}

