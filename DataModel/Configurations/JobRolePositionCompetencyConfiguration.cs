using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class JobRolePositionCompetencyConfiguration : IEntityTypeConfiguration<JobRolePositionCompetency>
    {
        public void Configure(EntityTypeBuilder<JobRolePositionCompetency> builder)
        {
            builder.HasKey(jgrpc => new { jgrpc.JobGroupId, jgrpc.JobGroupLevelId, jgrpc.JobPositionId, jgrpc.CompetencyId });
        }
    }
}
