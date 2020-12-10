using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{

    public class JobPositionCompetencyConfiguration : IEntityTypeConfiguration<JobPositionCompetency>
    {
        public void Configure(EntityTypeBuilder<JobPositionCompetency> builder)
        {
            builder.HasKey(cgr => new { cgr.JobPositionId, cgr.CompetencyId, cgr.CompetencyTypeId });

        }
    }
}
