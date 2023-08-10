using Application.Works.Dto;
using AutoMapper;
using Data.Entities;
using Web.Contracts;

namespace Web.Mapping;

/// <summary>
/// Профиль маппинга для контрактов запчастей
/// </summary>
public class WorksMappingProfile : Profile
{
    /// <summary>
    /// Профиль маппинга для контрактов запчастей
    /// </summary>
    public WorksMappingProfile()
    {
        CreateMap<WorkDto, WorkContract>();
    }
}