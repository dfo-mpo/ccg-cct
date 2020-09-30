using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel
{
    public class CrossReferenceNumber
    {
        public Guid Id { get; set; }
        public Guid InitialIntakeId { get; set; }
        public string CRNumber { get; set; }

        public VesselOfConcern VesselOfConcern { get; set; } 
    }
    public class CrossReferenceNumberConfiguration : IEntityTypeConfiguration<CrossReferenceNumber>
    {
        public void Configure(EntityTypeBuilder<CrossReferenceNumber> builder)
        {
        }
    }
}
