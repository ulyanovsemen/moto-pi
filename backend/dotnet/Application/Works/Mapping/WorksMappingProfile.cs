using Application.Common.Dto;
using Application.Works.Dto;
using AutoMapper;
using Data.Entities;

namespace Application.Works.Mapping;

public class WorksMappingProfile : Profile
{
    public WorksMappingProfile()
    {
        CreateMap<WorkType, DictionaryDto>();
        CreateMap<Work, WorkDto>();
    }
}