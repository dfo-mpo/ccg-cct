using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class SearchSimilarJobConfiguration : IEntityTypeConfiguration<SearchSimilarJob>
    {
        public void Configure(EntityTypeBuilder<SearchSimilarJob> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.Position)
                   .IsRequired();

            builder.Property(b => b.HundredPercent)
                   .HasMaxLength(8000);

            builder.Property(b => b.NinetyPercent)
                   .HasMaxLength(8000);

            builder.Property(b => b.EightyPercent)
                   .HasMaxLength(8000);

            builder.Property(b => b.SeventyPercent)
                  .HasMaxLength(8000);
        }
    }
}
