using Data.Configuration.Extensions;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration;

public class OrderWorkConfiguration : IEntityTypeConfiguration<OrderWork>
{
    public void Configure(EntityTypeBuilder<OrderWork> builder)
    {
        builder.ToTable("order_works");
        
        builder.ConfigureAsEntityBase();

        builder
            .HasOne(ow => ow.Work)
            .WithMany()
            .HasForeignKey(ow => ow.WorkId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder
            .HasOne(ow => ow.Employee)
            .WithMany()
            .HasForeignKey(ow => ow.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder
            .HasMany(o => o.Parts)
            .WithOne()
            .HasForeignKey(w => w.OrderWorkId)
            .OnDelete(DeleteBehavior.Restrict);

    }
}