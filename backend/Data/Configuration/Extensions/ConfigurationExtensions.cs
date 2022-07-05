using Data.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration.Extensions;

/// <summary>
/// Расширения для конфигураций
/// </summary>
public static class ConfigurationExtensions
{
    /// <summary>
    /// Сконфигурировать как <see cref="EntityBase"/>
    /// </summary>
    public static void ConfigureAsEntityBase<TEntity>(this EntityTypeBuilder<TEntity> builder)
        where TEntity : EntityBase
    {
        builder.Property(e => e.Id).UseIdentityByDefaultColumn();
        builder.HasKey(e => e.Id);
    }

    /// <summary>
    /// Сконфигурировать как <see cref="DictionaryEntityBase"/>
    /// </summary>
    /// <param name="builder"></param>
    /// <typeparam name="TEntity"></typeparam>
    public static void ConfigureAsDictionaryBase<TEntity>(this EntityTypeBuilder<TEntity> builder)
        where TEntity : DictionaryEntityBase
    {
        builder.ConfigureAsEntityBase();
        builder.Property(e => e.Name).IsRequired().HasComment("Наименование");
    }
}