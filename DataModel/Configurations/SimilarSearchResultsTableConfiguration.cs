using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class SimilarSearchResultsTableConfiguration : IEntityTypeConfiguration<SimilarSearchResultsTable>
    {
        public void Configure(EntityTypeBuilder<SimilarSearchResultsTable> builder)
        {
            builder.HasKey(jr => new { jr.JobGroupId, jr.JobGroupLevelId, jr.JobPositionId, jr.SearchPercentageId });
        }
    }
}
