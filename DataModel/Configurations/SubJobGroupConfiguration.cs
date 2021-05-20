using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class SubJobGroupConfiguration : IEntityTypeConfiguration<SubJobGroup>
    {
        public void Configure(EntityTypeBuilder<SubJobGroup> builder)
        {

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Code)
                .IsRequired()
                .HasMaxLength(250);
            builder.Property(b => b.NameEng)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(b => b.NameFre)
                .IsRequired()
                .HasMaxLength(500);
        }
    }
}

