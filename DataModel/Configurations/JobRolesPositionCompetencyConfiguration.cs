using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class JobRolesPositionCompetencyConfiguration : IEntityTypeConfiguration<JobRolesPositionCompetency>
    {
        public void Configure(EntityTypeBuilder<JobRolesPositionCompetency> builder)
        {
            builder.HasKey(jgrpc => new { jgrpc.JobGroupId, jgrpc.JobGroupLevelId, jgrpc.JobPositionId, jgrpc.CompetencyId });
        }
    }
}
