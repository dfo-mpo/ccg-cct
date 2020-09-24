using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public abstract class AbstractCodeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class, ICodeEntity
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasIndex(b => b.Code);

            builder.Property(b => b.SortOrder)
                .HasDefaultValue(0);
        }
    }
}
