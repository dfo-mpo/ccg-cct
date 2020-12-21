using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class CompetencyRatingLevelConfiguration : IEntityTypeConfiguration<CompetencyRatingLevel>
    {
        public void Configure(EntityTypeBuilder<CompetencyRatingLevel> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(b => b.NameEng)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(b => b.NameFre)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(b => b.DescFre)
               .HasMaxLength(1000);

            builder.Property(b => b.DescEng)
               .HasMaxLength(1000);
        }
    }
}
