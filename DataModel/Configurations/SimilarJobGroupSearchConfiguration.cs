using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class SimilarJobGroupSearchConfiguration : IEntityTypeConfiguration<SimilarJobGroupSearch>
    {
        public void Configure(EntityTypeBuilder<SimilarJobGroupSearch> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.JobGroup)
                .HasMaxLength(2500);

            builder.Property(b => b.SubJobGroup)
               .HasMaxLength(2500);

            builder.Property(b => b.HundredPercentResult)
               .HasMaxLength(2500);

            builder.Property(b => b.NineteenPercentResult)
               .HasMaxLength(2500);

            builder.Property(b => b.HeighteenPercentResult)
               .HasMaxLength(2500);

            builder.Property(b => b.SeventeenPercentResult)
              .HasMaxLength(2500);

        }
    }
}