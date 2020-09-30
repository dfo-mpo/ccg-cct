using System;
using System.Collections.Generic;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataModel.Configurations;

namespace DataModel.CodeTables
{
    public class StatusCode : ICodeEntity
    {
        public StatusCode()
        {
        }

        public Guid Id { get; set; } 
        public string Code { get; set; }
        public short SortOrder { get; set; }
        public bool IsActive { get; set; }

        public string DescEng { get; set; }
        public string DescFre { get; set; }


    }

    public class StatusConfiguration : AbstractCodeConfiguration<StatusCode>
    {
        public new void Configure(EntityTypeBuilder<StatusCode> builder)
        {
        }
    }

}
