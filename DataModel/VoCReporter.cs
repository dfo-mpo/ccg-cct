using System;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel
{
    public class VoCReporter : IEntity
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }

        public VesselOfConcern VesselOfConcern { get; set; }        
    }

    public class VoCReporterConfiguration : IEntityTypeConfiguration<VoCReporter>
    {
        public void Configure(EntityTypeBuilder<VoCReporter> builder)
        {
        }
    }


}
