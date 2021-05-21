using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{

    public class JobGroupPositionConfiguration : IEntityTypeConfiguration<JobGroupPosition>
    {
        public void Configure(EntityTypeBuilder<JobGroupPosition> builder)
        {
            builder.HasKey(jp => new { jp.JobGroupId, jp.SubJobGroupId, jp.JobGroupLevelId, jp.JobPositionId });

        }
    }
}

