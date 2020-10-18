using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
	public class GroupPositionTitle
    {
		// primary key
		[Key]
		public Guid Id { get; set; }

		// Proprietes

		[Column("PositionTitleEng")]
		public string PositionTitleEng { get; set; } // Ex: SAR Program Officer, ...

		[Column("PositionTitleFre")]
		public string PositionTitleFre { get; set; } // Ex: SAR Program Officer, ...


		// relationships
		

		[NotMapped]
		public virtual ICollection<GroupClassificationLevel> GroupClassificationLevels { get; set; }

		[NotMapped]
		public virtual ICollection<CompetencyType> CompetencyTypes { get; set; }

		[NotMapped]
		public virtual ICollection<Competency> Competencies { get; set; }

		[NotMapped]
		public virtual ICollection<JobGroup> JobGroups { get; set; }

	}
}
