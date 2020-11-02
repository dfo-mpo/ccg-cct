using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
    {
        public void Configure(EntityTypeBuilder<Certificate> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(b => b.Id);

            builder.Property(b => b.DescEng)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(b => b.DescFre)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(b => b.RequireIndicatorEng)
                .HasMaxLength(250);

            builder.Property(b => b.RequireIndicatorFre)
                .HasMaxLength(250);
        }
    }
}
