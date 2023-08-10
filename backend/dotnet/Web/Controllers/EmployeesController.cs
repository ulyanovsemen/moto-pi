using Application.Employees.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Web.Contracts;

namespace Web.Controllers;

/// <summary>
/// Контроллер сотрудников
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly IEmployeesService _employeesService;
    private readonly IMapper _mapper;

    /// <summary>
    /// Контроллер сотрудников
    /// </summary>
    public EmployeesController(IEmployeesService employeesService, IMapper mapper)
    {
        _employeesService = employeesService;
        _mapper = mapper;
    }
    
    /// <summary>
    /// Получить список сотрудников
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ICollection<EmployeeContract>> GetParts()
    {
        var dtos = await _employeesService.GetEmployees();

        return _mapper.Map<ICollection<EmployeeContract>>(dtos);
    }
}