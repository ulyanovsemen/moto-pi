using Application.Common.Base;
using Application.Works.Dto;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Works.Services;

/// <inheritdoc cref="IWorksService"/>
public class WorksService : ServiceBase, IWorksService
{
    /// <inheritdoc cref="IWorksService"/>
    public WorksService(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<WorkDto>> GetWorks()
    {
        return await Context.Works
            .OrderBy(p => p.Name)
            .ProjectTo<WorkDto>(Mapper.ConfigurationProvider)
            .ToListAsync();
    }

}