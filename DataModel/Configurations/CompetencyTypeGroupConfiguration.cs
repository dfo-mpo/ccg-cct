using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
   
   public class CompetencyTypeGroupConfiguration : IEntityTypeConfiguration<CompetencyTypeGroup>
    {
        public void Configure(EntityTypeBuilder<CompetencyTypeGroup> builder)
        {
           builder.HasKey(cgt => new { cgt.CompetencyId, cgt.CompetencyTypeId });
        }
    } 
   
}
