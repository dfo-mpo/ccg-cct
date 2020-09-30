using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel
{
    public class Classification
    {
        public Guid Id { get; set; } 
        public string Code { get; set; }
        public string DescEng { get; set; }
        public string DescFre { get; set; }
    }
    public class ClassificationConfiguration :  IEntityTypeConfiguration<Classification>
    {
        public void Configure(EntityTypeBuilder<Classification> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Code).IsRequired();
            builder.Property(e => e.DescEng).IsUnicode(false).HasMaxLength(255);
            builder.Property(e => e.DescFre).IsUnicode(false).HasMaxLength(255);
        }
    }

}
