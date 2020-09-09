using System;
using Api.Domain.Entities;
using Api.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

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

            var converter = new ValueConverter<TypeGeometricForm, string>
            (
                v => v.ToString(),
                v => (TypeGeometricForm)Enum.Parse(typeof(TypeGeometricForm), v)
            );

            builder.Property(e => e.Type)
                   .HasConversion(converter)
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
