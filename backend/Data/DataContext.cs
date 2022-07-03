using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

/// <summary>
/// Контекст данных приложения
/// </summary>
public class DataContext : DbContext
{
    /// <summary>
    /// Контекст данных приложения
    /// </summary>
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    /// <summary>
    /// Справочник типов запчастей
    /// </summary>
    public DbSet<PartType> PartTypes { get; set; }
    
    /// <summary>
    /// Справочник запчастей
    /// </summary>
    public DbSet<Part> Parts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
    }
}