using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class CompetencyRatingGroupConfiguration : IEntityTypeConfiguration<CompetencyRatingGroup>
    {
            public void Configure(EntityTypeBuilder<CompetencyRatingGroup> builder)
            {
                builder.HasKey(cgr => new { cgr.CompetencyId, cgr.CompetencyRatingLevelId, cgr.CompetencyLevelRequirementId});
            }
        
    }
}
