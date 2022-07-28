using Application.Employees.Dto;
using AutoMapper;
using Data.Entities;

namespace Application.Employees.Mapping;

/// <summary>
/// Профиль маппинга для запчастей
/// </summary>
public class EmployeesMappingProfile : Profile
{
    public EmployeesMappingProfile()
    {
        CreateMap<Employee, EmployeeDto>();
    }
}