using Application.Orders.Dto;
using AutoMapper;
using Web.Contracts;

namespace Web.Mapping;

/// <summary>
/// Профиль маппинга для контрактов заказов
/// </summary>
public class OrdersMappingProfile : Profile
{
    /// <summary>
    /// Профиль маппинга для контрактов запчастей
    /// </summary>
    public OrdersMappingProfile()
    {
        CreateMap<OrderCreateContract, OrderCreateDto>();
        CreateMap<PersonCreateContract, PersonCreateDto>();
        CreateMap<ManufacturerCreateContract, ManufacturerCreateDto>();
        CreateMap<VehicleModelCreateContract, VehicleModelCreateDto>();
        CreateMap<VehicleCreateContract, VehicleCreateDto>();
    }
}