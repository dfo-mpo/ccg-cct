using System;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel
{
    
    public class VoCRiskScore : IEntity
    {
        //public VoCRiskScore()
        //{
        //    Id = Guid.NewGuid();
        //}

        public Guid Id { get; set; }
        public Guid RiskRangeId { get; set; } // (1) one to one FK from RiskRange
        public DateTime RiskScoreDate { get; set; }

        // VoCReporter is the Dependent Entity containing the following reference navigation properties:
        public RiskRange RiskRange { get; set; }
    }
    public class VoCRiskScoreConfiguration : IEntityTypeConfiguration<VoCRiskScore>
    {
        public void Configure(EntityTypeBuilder<VoCRiskScore> builder)
        {
        }
    }

}
