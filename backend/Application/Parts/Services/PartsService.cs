using Application.Common.Base;
using Application.Parts.Dto;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Parts.Services;

/// <inheritdoc cref="IPartsService"/>
public class PartsService : ServiceBase, IPartsService
{
    /// <inheritdoc cref="IPartsService"/>
    public PartsService(DataContext context, IMapper mapper) : base (context, mapper)
    {
    }
    
    /// <inheritdoc/>
    public async Task<ICollection<PartDto>> GetParts()
    {
        return await Context.Parts
            .OrderBy(p => p.Name)
            .ProjectTo<PartDto>(Mapper.ConfigurationProvider)
            .ToListAsync();
    }
}