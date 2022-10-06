using Application.Orders.Dto;
using Application.Orders.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Web.Contracts;

namespace Web.Controllers;

/// <summary>
/// Контроллер заказов
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IOrdersService _ordersService;

    /// <summary>
    /// Контроллер заказов
    /// </summary>
    public OrdersController(IMapper mapper, IOrdersService ordersService)
    {
        _mapper = mapper;
        _ordersService = ordersService;
    }

    /// <summary>
    /// Создать заказ
    /// </summary>
    /// <returns>Идентификатор - номер кнтракта</returns>
    [HttpPost]
    public async Task<long> Create(OrderCreateContract createContract)
    {
        return await _ordersService.Create(_mapper.Map<OrderCreateDto>(createContract));
    }
}