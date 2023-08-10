using Application.Orders.Dto;

namespace Application.Orders.Services;

/// <summary>
/// Сервис заказов
/// </summary>
public interface IOrdersService
{
    /// <summary>
    /// Создать заказ
    /// </summary>
    Task<long> Create(OrderCreateDto createDto);
}