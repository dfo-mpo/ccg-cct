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

            builder.Property(b => b.NameEng)
                .HasMaxLength(1000);

            builder.Property(b => b.NameFre)
               .HasMaxLength(1000);

            builder.Property(b => b.DescEng)
               .HasMaxLength(1000);

            builder.Property(b => b.DescFre)
              .HasMaxLength(1000);

            builder.Property(b => b.Active)
                .IsRequired();

        }
    } 
}
