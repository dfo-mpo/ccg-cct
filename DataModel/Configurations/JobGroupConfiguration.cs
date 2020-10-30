using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
   public class JobGroupConfiguration : IEntityTypeConfiguration<JobGroup>
    {
        public void Configure(EntityTypeBuilder<JobGroup> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(b => b.ClassificationName)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
