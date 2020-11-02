using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataModel.Configurations
{
   public class JobKeyTaskPerLevelConfiguration : IEntityTypeConfiguration<JobKeyTaskPerLevel>
    {
        public void Configure(EntityTypeBuilder<JobKeyTaskPerLevel> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(b => b.DescEng)
                .HasMaxLength(250);

            builder.Property(b => b.DescFre)
                .HasMaxLength(250);
        }
    }
}
