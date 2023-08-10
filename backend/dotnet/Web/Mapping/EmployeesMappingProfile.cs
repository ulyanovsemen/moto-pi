using Application.Employees.Dto;
using AutoMapper;
using Web.Contracts;

namespace Web.Mapping;

/// <summary>
/// Профиль маппинга для контрактов запчастей
/// </summary>
public class EmployeesMappingProfile : Profile
{
    /// <summary>
    /// Профиль маппинга для контрактов запчастей
    /// </summary>
    public EmployeesMappingProfile()
    {
        CreateMap<EmployeeDto, EmployeeContract>();
    }
}