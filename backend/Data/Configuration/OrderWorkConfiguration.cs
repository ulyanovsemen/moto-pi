using Data.Configuration.Extensions;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration;

public class OrderWorkPartConfiguration : IEntityTypeConfiguration<OrderWorkPart>
{
    public void Configure(EntityTypeBuilder<OrderWorkPart> builder)
    {
        builder.ToTable("order_work_parts");
        
        builder.ConfigureAsEntityBase();

        builder
            .HasOne(owp => owp.Part)
            .WithMany()
            .HasForeignKey(owp => owp.PartId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}