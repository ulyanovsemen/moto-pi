using Application.Common.Dto;
using Application.Parts.Dto;
using AutoMapper;
using Web.Contracts;

namespace Web.Mapping;

/// <summary>
/// Профиль маппинга для контрактов запчастей
/// </summary>
public class PartsMappingProfile : Profile
{
    /// <summary>
    /// Профиль маппинга для контрактов запчастей
    /// </summary>
    public PartsMappingProfile()
    {
        CreateMap<DictionaryDto, DictionaryContract>();
        CreateMap<PartDto, PartContract>();
    }
}