using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Seeding;

public class WorksSeeding : IEntityTypeConfiguration<Work>
{
    public void Configure(EntityTypeBuilder<Work> builder)
    {
        builder.HasData(
            new Work() { Id = 1, WorkTypeId = 1, Name = "Замена стойки амортизатора" },
            new Work() { Id = 2, WorkTypeId = 1, Name = "Замена пружины" },
            new Work() { Id = 3, WorkTypeId = 2, Name = "Замена масла" }
        );
    }
}