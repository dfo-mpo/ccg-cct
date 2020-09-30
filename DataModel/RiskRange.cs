using System;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel
{
    public class RiskRange : IDescription, IEntity
    {
        //public RiskRange()
        //{
        //    Id = Guid.NewGuid();
        //}

        public Guid Id { get; set; }
        public string DescEng { get; set; }
        public string DescFre { get; set; }

        // RiskRange is the Principal Entity containing the following reference navigation properties:
        public VoCRiskScore VoCRiskScore { get; set; }

    }
    public class RiskRangeConfiguration : IEntityTypeConfiguration<RiskRange>
    {
        public void Configure(EntityTypeBuilder<RiskRange> builder)
        {
            builder.Property(e => e.DescEng).IsRequired();
            builder.Property(e => e.DescFre).IsRequired();
        }
    }
}
