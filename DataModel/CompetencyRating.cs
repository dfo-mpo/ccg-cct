using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel
{
	public class CompetencyRating
	{
		// Primary key
		[Key]
		public Guid Id { get; set; }

		// Properties

		[Column("CompetencyRatingLevel")]
		public int CompetencyRatingLevel { get; set; }

		[Column("CompetencyRatingNameEng")]
		public string CompetencyRatingNameEng { get; set; }

		[Column("CompetencyRatingNameFre")]
		public string CompetencyRatingNameFre { get; set; }

		[Column("RatingDefinitionEng")]
		public string RatingDefinitionEng { get; set; }

		[Column("RatingDefinitionFre")]
		public string RatingDefinitionFre { get; set; }

		// Relationships

		
		public ICollection<Competency> Competencies { get; set; }
	}

}
