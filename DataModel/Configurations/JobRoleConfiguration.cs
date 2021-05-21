using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class JobRoleConfiguration : IEntityTypeConfiguration<JobRole>
    {
        public void Configure(EntityTypeBuilder<JobRole> builder)
        {
            builder.HasKey(jr => new { jr.JobGroupId, jr.SubJobGroupId, jr.JobGroupLevelId });
        }
    }
}
