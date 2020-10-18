using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class GroupClassificationLevel
    {
        // Primary key 
        [Key]
        public Guid Id { get; set; }
        
        // Proprietes

        [Column("ClassificationLevel")]
        public string ClassificationLevel { get; set; } // Ex: 01, 02,... 13

        // relationships
        
        [NotMapped]
        public virtual ICollection<JobGroup> JobGroups { get; set; }
    }
}
