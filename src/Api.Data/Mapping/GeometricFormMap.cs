using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class GeometricFormMap : IEntityTypeConfiguration<GeometricFormEntity>
    {
        public void Configure(EntityTypeBuilder<GeometricFormEntity> builder)
        {
            builder.ToTable("GeometricForm");

            builder.HasKey(g => g.Id);


            builder.Property(g => g.Name)
                   .IsRequired()
                   .HasMaxLength(60);

            builder.Property(e => e.Type)
                   .IsRequired();

            builder.Property(g => g.Color)
                   .IsRequired()
                   .HasMaxLength(60);

            builder.Property(g => g.Size)
                   .IsRequired()
                   .HasMaxLength(60);
        }
    }
}
