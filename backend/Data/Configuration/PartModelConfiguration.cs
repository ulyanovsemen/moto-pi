using Data.Configuration.Extensions;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration;

public class PartModelConfiguration : IEntityTypeConfiguration<PartModel>
{
    public void Configure(EntityTypeBuilder<PartModel> builder)
    {
        builder.ToTable("part_models");
        
        builder.ConfigureAsDictionaryBase();

        builder
            .HasOne(pm => pm.Manufacturer)
            .WithMany()
            .HasForeignKey(pm => pm.ManufacturerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}