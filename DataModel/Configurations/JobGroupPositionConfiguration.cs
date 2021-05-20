using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using DataModel.Configurations;
using DataModel.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataModel.Configurations
{

    public class JobGroupPositionConfiguration : IEntityTypeConfiguration<JobGroupPosition>
    {
        public void Configure(EntityTypeBuilder<JobGroupPosition> builder)
        {
           builder.HasKey(jp => jp.Id);

        }
    }
}

