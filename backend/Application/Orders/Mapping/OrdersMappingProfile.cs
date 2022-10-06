using Application.Orders.Dto;
using AutoMapper;
using Data.Entities;

namespace Application.Orders.Mapping;

/// <summary>
/// Профиль маппинга для заказов
/// </summary>
public class OrdersMappingProfile : Profile
{
    public OrdersMappingProfile()
    {
        CreateMap<OrderCreateDto, Order>()
            .ForMember(d => d.CreateDate, o => o.Ignore())
            .ForMember(d => d.Customer, o => o.Ignore())
            .ForMember(d => d.Vehicle, o => o.Ignore())
            .ForMember(d => d.Works, o => o.Ignore())
            .ForMember(d => d.ChangeDate, o => o.Ignore())
            ;

        CreateMap<PersonCreateDto, Customer>();
    }
}