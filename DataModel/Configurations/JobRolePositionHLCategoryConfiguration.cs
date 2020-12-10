using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class JobRolePositionHLCategoryConfiguration : IEntityTypeConfiguration<JobRolePositionHLCategory>
    {
        public void Configure(EntityTypeBuilder<JobRolePositionHLCategory> builder)
        {
            builder.HasKey(jp => new { jp.JobGroupId, jp.JobGroupLevelId, jp.JobPositionId, jp.JobHLCategoryId });
        }
    }
}
