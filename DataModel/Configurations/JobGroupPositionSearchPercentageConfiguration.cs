using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class JobGroupPositionSearchPercentageConfiguration : IEntityTypeConfiguration<JobGroupPositionSearchPercentage>
    {
        public void Configure(EntityTypeBuilder<JobGroupPositionSearchPercentage> builder)
        {
            builder.HasKey(jp => new {jp.JobGroupPositionId, jp.JobGroupId, jp.SubJobGroupId,jp.JobGroupLevelId, jp.JobPositionId, jp.SearchPercentageId });
        }
    }
}
