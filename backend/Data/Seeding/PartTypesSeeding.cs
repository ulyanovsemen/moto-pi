using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Seeding;

public class PartTypesSeeding : IEntityTypeConfiguration<PartType>
{
    public void Configure(EntityTypeBuilder<PartType> builder)
    {
        builder.HasData(
            new PartType() { Id = 1, Name = "Подвеска" },
            new PartType() { Id = 2, Name = "Двигатель" }
        );
    }
}