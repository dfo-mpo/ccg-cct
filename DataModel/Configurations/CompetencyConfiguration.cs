using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class CompetencyConfiguration : IEntityTypeConfiguration<Competency>
    {
        public void Configure(EntityTypeBuilder<Competency> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(b => b.NameEng)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(b => b.NameFre)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(b => b.DescEng)
                .IsRequired()
                .HasMaxLength(2500);

            builder.Property(b => b.DescFre)
                .IsRequired()
                .HasMaxLength(2500);

            builder.Property(b => b.Active)
               .IsRequired();
        }
    }
}
