using Application.Common.Base;
using Application.Employees.Dto;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Employees.Services;

/// <inheritdoc cref="IEmployeesService"/>
public class EmployeesService : ServiceBase, IEmployeesService
{
    /// <inheritdoc cref="IEmployeesService"/>
    public EmployeesService(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }

    /// <inheritdoc/>
    public async Task<ICollection<EmployeeDto>> GetEmployees()
    {
        return await Context.Employees
            .OrderBy(e => e.Fio)
            .ProjectTo<EmployeeDto>(Mapper.ConfigurationProvider)
            .ToListAsync();
    }
}