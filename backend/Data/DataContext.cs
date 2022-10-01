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
    /// Справочник заказчиков
    /// </summary>
    public DbSet<Customer> Customers { get; set; }

    /// <summary>
    /// Справочник сотрудников
    /// </summary>
    public DbSet<Employee> Employees { get; set; }

    /// <summary>
    /// Справочник производителей
    /// </summary>
    public DbSet<Manufacturer> Manufacturers { get; set; }

    /// <summary>
    /// Заказы
    /// </summary>
    public DbSet<Order> Orders { get; set; }

    /// <summary>
    /// Работы заказов
    /// </summary>
    public DbSet<OrderWork> OrderWorks { get; set; }

    /// <summary>
    /// Запчасти, использованные в работах заказов
    /// </summary>
    public DbSet<OrderWorkPart> OrderWorkParts { get; set; }

    /// <summary>
    /// Справочник запчастей
    /// </summary>
    public DbSet<Part> Parts { get; set; }

    /// <summary>
    /// Справочник марок запчастей
    /// </summary>
    public DbSet<PartModel> PartModels { get; set; }

    /// <summary>
    /// Справочник типов запчастей
    /// </summary>
    public DbSet<PartType> PartTypes { get; set; }
  
    /// <summary>
    /// Справочник ТС
    /// </summary>
    public DbSet<Vehicle> Vehicles { get; set; }

    /// <summary>
    /// Справочник марок ТС
    /// </summary>
    public DbSet<VehicleModel> VehicleModels { get; set; }

    /// <summary>
    /// Справочник работ
    /// </summary>
    public DbSet<Work> Works { get; set; }

    /// <summary>
    /// Справочник видов работ
    /// </summary>
    public DbSet<WorkType> WorkTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
    }
}