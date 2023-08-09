using Application.Common.Dto;
using Application.Parts.Dto;
using AutoMapper;
using Data.Entities;

namespace Application.Parts.Mapping;

/// <summary>
/// Профиль маппинга для запчастей
/// </summary>
public class PartsMappingProfile : Profile
{
    public PartsMappingProfile()
    {
        CreateMap<PartType, DictionaryDto>();
        CreateMap<Part, PartDto>();
    }
}