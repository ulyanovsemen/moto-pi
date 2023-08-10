using Application.Common.Services;
using Application.Orders.Dto;
using AutoMapper;
using Data;
using Data.Entities;

namespace Application.Orders.Services;

/// <inheritdoc/>
public class OrdersService : IOrdersService
{
    private readonly IMapper _mapper;
    private readonly DataContext _context;
    private readonly ITimeService _timeService;

    /// <inheritdoc cref="IOrdersService"/>
    public OrdersService(IMapper mapper, DataContext context, ITimeService timeService)
    {
        _mapper = mapper;
        _context = context;
        _timeService = timeService;
    }

    /// <inheritdoc/>
    public async Task<long> Create(OrderCreateDto createDto)
    {
        await using var transaction = await _context.Database.BeginTransactionAsync();

        var newOrder = _mapper.Map<Order>(createDto, o =>
            o.AfterMap((_, d) =>
            {
                var currentDate = _timeService.UtcNow();

                d.CreateDate = currentDate;
                d.ChangeDate = currentDate;
            }));

        if (!createDto.CustomerId.HasValue)
            await AddNewCustomer(newOrder, createDto.NewCustomer);

        if (!createDto.VehicleId.HasValue)
            await AddNewVehicle(newOrder, createDto.NewVehicle);
        
        await _context.Orders.AddAsync(newOrder);
        await _context.SaveChangesAsync();

        await transaction.CommitAsync();

        return newOrder.Id;
    }

    private async Task AddNewCustomer(Order order, PersonCreateDto customerDto)
    {
        if (customerDto is null)
            throw new ArgumentNullException(nameof(customerDto));

        var newCustomer = _mapper.Map<Customer>(customerDto);
        await _context.Customers.AddAsync(newCustomer);
        order.Customer = newCustomer;
    }

    private async Task AddNewVehicle(Order order, VehicleCreateDto vehicleCreateDto)
    {
        
    }
}