using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    
    public class CertificateDescriptionConfiguration : IEntityTypeConfiguration<CertificateDescription>
    {
       
        public void Configure(EntityTypeBuilder<CertificateDescription> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.DescEng)
                .HasMaxLength(1000);

            builder.Property(b => b.DescFre)
               .HasMaxLength(1000);
        }
    } 
}
