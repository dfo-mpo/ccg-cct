using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataModel.Configurations
{
    public class JobRolePositionCertificateConfiguration : IEntityTypeConfiguration<JobRolePositionCertificate>
    {
        public void Configure(EntityTypeBuilder<JobRolePositionCertificate> builder)
        {
            builder.HasKey(jp => new {jp.JobGroupId, jp.SubJobGroupId, jp.JobGroupLevelId, jp.JobPositionId, jp.CertificateId, jp.CertificateDescriptionId });
        }
    }
}
