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

            builder.HasKey(x => x.Id);

            builder.Property(b => b.SubCode)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}

