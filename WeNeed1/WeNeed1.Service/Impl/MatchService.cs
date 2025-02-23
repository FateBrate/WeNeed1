using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WeNeed1.Model.Enums;
using WeNeed1.Model.Exceptions;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service.Database;

namespace WeNeed1.Service.Impl;

public class MatchService : BaseCRUDService<MatchResponseDto, Match, MatchSearchObject, MatchRequestDto, MatchRequestDto>, IMatchService
{
    public MatchService(WeNeed1Context context, IMapper mapper) : base(context, mapper) { }

    public override async Task<MatchResponseDto> Insert(MatchRequestDto request)
    {
        var teamExists = await _context.Teams.AnyAsync(t => t.Id == request.TeamId);
        if (!teamExists)
        {
            throw new UserException("Invalid TeamId: Team does not exist.");
        }
        var entity = _mapper.Map<Match>(request);
        
        entity.Result = "0:0";
        entity.Status = MatchStatus.CREATED;

        await _context.Matches.AddAsync(entity);
        await _context.SaveChangesAsync();

        return _mapper.Map<MatchResponseDto>(entity);
    }
    
    public override IQueryable<Match> AddFilter(IQueryable<Match> query, MatchSearchObject search)
    {
        if (search.TeamId.HasValue)
        {
            query = query.Where(m => m.TeamId == search.TeamId.Value);
        }

        if (search.Status.HasValue)
        {
            query = query.Where(m => m.Status == search.Status.Value);
        }

        return query;
    }
}