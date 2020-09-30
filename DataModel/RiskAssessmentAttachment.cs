using System;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel
{
    public class RiskAssessmentAttachment : IEntity
    {
        //public RiskAssessmentAttachment()
        //{
        //    Id = Guid.NewGuid();
        //}

        public Guid Id { get; set; }
        public Guid RiskAssessmentId { get; set; } 
        public Boolean MainAttachmentFlag { get; set; }
        public byte[] AttachedFile { get; set; } 
        public virtual RiskAssessment RiskAssessment { get; set; }
    }

    public class RiskAssessmentAttachmentConfiguration : IEntityTypeConfiguration<RiskAssessmentAttachment>
    {
        public void Configure(EntityTypeBuilder<RiskAssessmentAttachment> builder)
        {
                 builder.HasOne(e => e.RiskAssessment)
                .WithMany(e => e.RiskAssessmentAttachments)
                .HasForeignKey(e => e.RiskAssessmentId);
        }
    }

}
