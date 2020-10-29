using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
   public class CompetencyGroupsTypeConfiguration : IEntityTypeConfiguration<CompetencyGroupsType>
    {
        public void Configure(EntityTypeBuilder<CompetencyGroupsType> builder)
        {
            builder.HasKey(cgt => new { cgt.CompetencyId, cgt.CompetencyTypeId });
        }
    }
}
