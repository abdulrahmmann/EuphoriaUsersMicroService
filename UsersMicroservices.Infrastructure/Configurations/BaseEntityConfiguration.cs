using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UsersMicroservices.Domain.Bases;

namespace UsersMicroservices.Infrastructure.Configurations;

public abstract class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Entity<int>
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasKey(be => be.Id);

        builder.Property(be => be.Id)
            .ValueGeneratedOnAdd();

        builder.Property(e => e.CreatedAt)
            .HasColumnType("timestamp(6) without time zone")
            .HasDefaultValueSql("CURRENT_TIMESTAMP(6)") 
            .ValueGeneratedOnAdd();

        builder.Property(e => e.LastModified)
            .HasColumnType("timestamp(6) without time zone")
            .HasDefaultValueSql("CURRENT_TIMESTAMP(6)")
            .ValueGeneratedOnAddOrUpdate();

        builder.Property(e => e.CreatedBy)
            .HasMaxLength(100)
            .IsRequired(false);

        builder.Property(e => e.LastModifiedBy)
            .HasMaxLength(100)
            .IsRequired(false);
    }
}