using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataModel.Configurations
{
    public class SearchPercentageConfiguration : IEntityTypeConfiguration<SearchPercentage>
    {
        public void Configure(EntityTypeBuilder<SearchPercentage> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.Value)
                .IsRequired()
                .HasMaxLength(250);
        }

    }
}
