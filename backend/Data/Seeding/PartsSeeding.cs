using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Seeding;

public class PartsSeeding : IEntityTypeConfiguration<Part>
{
    public void Configure(EntityTypeBuilder<Part> builder)
    {
        builder.HasData(
            new Part() { Id = 1, PartTypeId = 1, Name = "Стойка амортизатора", Model = "BMW", Number = "12345QWE" },
            new Part() { Id = 2, PartTypeId = 1, Name = "Пружина", Model = "BMW", Number = "ZXC123" },
            new Part() { Id = 3, PartTypeId = 2, Name = "Поршень", Model = "Bosh", Number = "ZXC123" }
        );
    }
}