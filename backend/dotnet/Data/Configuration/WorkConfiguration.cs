using Data.Configuration.Extensions;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration;

public class WorkConfiguration : IEntityTypeConfiguration<Work>
{
    public void Configure(EntityTypeBuilder<Work> builder)
    {
        builder.ToTable("works");
        
        builder.ConfigureAsDictionaryBase();

        builder
            .HasOne(p => p.Type)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
    }
}