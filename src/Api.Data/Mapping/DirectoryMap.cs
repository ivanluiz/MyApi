using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class DirectoryMap : IEntityTypeConfiguration<DirectoryEntity>
    {
        public void Configure(EntityTypeBuilder<DirectoryEntity> builder)
        {
            builder.ToTable("Directory");

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Name)
                   .IsRequired();
        }
    }
}
