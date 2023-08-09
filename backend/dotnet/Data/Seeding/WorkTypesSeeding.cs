using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Seeding;

public class WorkTypesSeeding : IEntityTypeConfiguration<WorkType>
{
    public void Configure(EntityTypeBuilder<WorkType> builder)
    {
        builder.HasData(
            new WorkType() { Id = 1, Name = "Подвеска"},
            new WorkType() { Id = 2, Name = "Двигатель"}
            );
    }
}