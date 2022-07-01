using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

/// <summary>
/// Контекст данных приложения
/// </summary>
public class DataContext : DbContext
{
    /// <summary>
    /// Справочник запчастей
    /// </summary>
    public DbSet<Part> Parts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
    }
}