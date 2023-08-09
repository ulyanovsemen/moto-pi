using AutoMapper;
using Data;

namespace Application.Common.Base;

/// <summary>
/// Базовый класс для сервисов приложения
/// </summary>
public abstract class ServiceBase
{
    protected readonly DataContext Context;
    protected readonly IMapper Mapper;

    /// <summary>
    /// Базовый класс для сервисов приложения
    /// </summary>
    public ServiceBase(DataContext context, IMapper mapper)
    {
        Context = context;
        Mapper = mapper;
    }
}