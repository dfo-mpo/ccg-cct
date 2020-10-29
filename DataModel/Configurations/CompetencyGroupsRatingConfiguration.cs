using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataModel.Configurations
{
    public class CompetencyGroupsRatingConfiguration : IEntityTypeConfiguration<CompetencyGroupsRating>
    {
            public void Configure(EntityTypeBuilder<CompetencyGroupsRating> builder)
            {
                builder.HasKey(cgr => new { cgr.CompetencyId, cgr.CompetencyRatingLevelId, cgr.CompetencyLevelRequirementId});
            }
        
    }
}
