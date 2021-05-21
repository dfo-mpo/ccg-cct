using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class JobRolePositionCompetencyRatingConfiguration : IEntityTypeConfiguration<JobRolePositionCompetencyRating>
    {

        public void Configure(EntityTypeBuilder<JobRolePositionCompetencyRating> builder)
        {

            builder.HasKey(cgr => new { cgr.JobGroupId, cgr.SubJobGroupId, cgr.JobGroupLevelId, cgr.JobPositionId, cgr.CompetencyId, cgr.CompetencyTypeId, cgr.CompetencyRatingLevelId, cgr.CompetencyLevelRequirementId });

        }
    }
}

