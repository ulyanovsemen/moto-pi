using Application.Parts.Dto;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Parts.Services;

/// <inheritdoc/>
public class PartsService : IPartsService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    /// <inheritdoc cref="IPartsService"/>
    public PartsService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    /// <inheritdoc/>
    public async Task<ICollection<PartDto>> GetParts()
    {
        return await _context.Parts
            .OrderBy(p => p.Name)
            .ProjectTo<PartDto>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
}