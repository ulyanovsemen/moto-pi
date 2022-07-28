using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Seeding;

public class EmployeesSeeding : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasData(
            new Employee { Id = 1, Fio = "Иванов Иван Иванович", TelNumber = "8-800-555-3535" }
        );
    }
}