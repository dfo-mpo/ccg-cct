using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class SimilarSearchResultsConfiguration : IEntityTypeConfiguration<SimilarSearchResults>
    {
        public void Configure(EntityTypeBuilder<SimilarSearchResults> builder)
        {
            builder.HasKey(jr => new { jr.JobGroupId, jr.JobGroupLevelId, jr.JobPositionId, jr.SearchPercentageId });
        }
    }
}
