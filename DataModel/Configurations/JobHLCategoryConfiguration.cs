using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class JobHLCategoryConfiguration : IEntityTypeConfiguration<JobHLCategory>
    {
        public void Configure(EntityTypeBuilder<JobHLCategory> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.ValueEng)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(b => b.ValueFre)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}

