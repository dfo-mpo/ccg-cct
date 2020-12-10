using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
   public class CompetencyLevelRequirementConfiguration : IEntityTypeConfiguration<CompetencyLevelRequirement>
    {
        public void Configure(EntityTypeBuilder<CompetencyLevelRequirement> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(b => b.DescEng)
                .HasMaxLength(8000);

            builder.Property(b => b.DescFre)
                .HasMaxLength(8000);
        }
    }
}
