using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class JobPositionConfiguration : IEntityTypeConfiguration<JobPosition>
    {
        public void Configure(EntityTypeBuilder<JobPosition> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(b => b.TitleEng)
                .IsRequired()
                .HasMaxLength(3000);

            builder.Property(b => b.TitleFre)
                .IsRequired()
                .HasMaxLength(3000);

            builder.Property(b => b.Active)
               .IsRequired();
        }
    }
}
