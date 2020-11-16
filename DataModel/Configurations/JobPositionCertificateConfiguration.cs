using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel
{
    public class JobPositionCertificateConfiguration : IEntityTypeConfiguration<JobPositionCertificate>
    {
        public void Configure(EntityTypeBuilder<JobPositionCertificate> builder)
        {
            builder.HasKey(jp => new {jp.JobPositionId, jp.CertificateId });
        }
    }
}
