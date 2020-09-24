using System;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel
{
    public class VesselName : IEntity
    {
        //public VesselName()
        //{
        //    Id = Guid.NewGuid();
        //}

        public Guid Id { get; set; }
        public Guid VesselRegistrationId { get; set; }
        public string Name { get; set; }
        public string PreviousName { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime EndDate { get; set; }

        // VesselName is Dependent Entity in following navigation property references --------------
        public VesselRegistration VesselRegistration { get; set; } //each (vessel) name can be associated with only 1 vessel registration id.
    }

    public class VesselNameConfiguration : IEntityTypeConfiguration<VesselName>
    {
        public void Configure(EntityTypeBuilder<VesselName> builder)
        {
        }
    }
}
