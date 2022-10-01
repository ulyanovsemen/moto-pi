using Data.Configuration.Extensions;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration;

public class PartConfiguration : IEntityTypeConfiguration<Part>
{
    public void Configure(EntityTypeBuilder<Part> builder)
    {
        builder.ToTable("parts");
        
        builder.ConfigureAsDictionaryBase();

        builder
            .HasOne(p => p.Type)
            .WithMany()
            .HasForeignKey(p => p.PartTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(p => p.Model)
            .WithMany()
            .HasForeignKey(p => p.PartModelId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}