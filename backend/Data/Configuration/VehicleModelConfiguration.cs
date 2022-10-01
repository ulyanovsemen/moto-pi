using Data.Configuration.Extensions;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration;

public class VehicleModelConfiguration : IEntityTypeConfiguration<VehicleModel>
{
    public void Configure(EntityTypeBuilder<VehicleModel> builder)
    {
        builder.ToTable("vehicle_models");
        
        builder.ConfigureAsDictionaryBase();

        builder
            .HasOne(vm => vm.Manufacturer)
            .WithMany()
            .HasForeignKey(vm => vm.ManufacturerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}