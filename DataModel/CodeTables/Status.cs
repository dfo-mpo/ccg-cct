using System;
using System.Collections.Generic;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataModel.Configurations;

namespace DataModel.CodeTables
{
    public class Status : ICodeEntity
    {
        public Status()
        {
            Children = new HashSet<Status>();
        }

        public Guid Id { get; set; } 
        public Guid? ParentStatusId { get; set; } 
        public string Code { get; set; }
        public short SortOrder { get; set; }
        public bool IsActive { get; set; }

        public string DescEng { get; set; }
        public string DescFre { get; set; }

        public Status Parent { get; set; }
        public virtual ICollection<Status> Children { get; set; }

    }

    public class StatusConfiguration : AbstractCodeConfiguration<Status>
    {
        public new void Configure(EntityTypeBuilder<Status> builder)
        {
            builder
            .HasMany(e => e.Children)
            .WithOne(e => e.Parent)
            .HasForeignKey(e => e.ParentStatusId);

            builder.Property(e => e.DescEng).IsRequired();
            builder.Property(e => e.DescFre).IsRequired();
        }
    }

}
