﻿using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
   public  class CompetencyTypeConfiguration : IEntityTypeConfiguration<CompetencyType>
    {
        public void Configure(EntityTypeBuilder<CompetencyType> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(b => b.NameEng)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(b => b.NameFre)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
