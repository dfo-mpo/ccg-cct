using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class JobRolePositionLocationConfiguration : IEntityTypeConfiguration<JobRolePositionLocation>
    {
        public void Configure(EntityTypeBuilder<JobRolePositionLocation> builder)
        {
            builder.HasKey(jp => new { jp.JobGroupId, jp.JobGroupLevelId, jp.JobPositionId, jp.JobLocationRegionId });
        }
    }
}
