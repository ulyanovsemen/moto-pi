using Data.Configuration.Extensions;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration;

public class PartTypeConfiguration : IEntityTypeConfiguration<PartType>
{
    public void Configure(EntityTypeBuilder<PartType> builder)
    {
        builder.ToTable("part_types");
        
        builder.ConfigureAsDictionaryBase();
    }
}