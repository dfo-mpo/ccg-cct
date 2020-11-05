using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class JobGroupLevelConfiguration : IEntityTypeConfiguration<JobGroupLevel>
    {
        public void Configure(EntityTypeBuilder<JobGroupLevel> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(b => b.LevelValue)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
