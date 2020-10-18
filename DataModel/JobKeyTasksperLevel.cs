using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class JobKeyTasksperLevel
    {
        // Primary key 
        [Key]
        public Guid Id { get; set; }

        // Properties

        [Column("JobKeyTasksperLevelEng")]
        public string JobKeyTasksperLevelEng { get; set; }

        [Column("JobKeyTasksperLevelFre")]
        public string JobKeyTasksperLevelFre { get; set; }

        [NotMapped]
        public virtual ICollection<JobGroup> JobGroups { get; set; }
    }

}
