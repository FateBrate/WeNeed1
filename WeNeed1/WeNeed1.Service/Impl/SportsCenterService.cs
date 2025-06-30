using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service.Database;

namespace WeNeed1.Service.Impl;

public class SportsCenterService : BaseCRUDService<SportsCenterResponseDto, SportsCenter, SportCenterSearchObject, SportsCenterRequestDto, SportsCenterRequestDto>, ISportsCenterService
{
    private readonly IUserService _userService;
    public SportsCenterService(WeNeed1Context context, IMapper mapper, IUserService userService) : base(context, mapper)
    {
        _userService = userService;
    }
    
    public async Task<SportsCenterResponseDto> GetMySportsCenterAsync()
    {
        var user = await _userService.GetCurrentUserAsync();

        var sportsCenter = await _context.SportsCenters
            .Include(sc => sc.SportsFields)
            .FirstOrDefaultAsync(sc => sc.ManagerId == user.Id);

        if (sportsCenter == null)
            throw new Exception("Sports center not found for this manager.");

        return _mapper.Map<SportsCenterResponseDto>(sportsCenter);
    }

    public override IQueryable<SportsCenter> AddFilter(IQueryable<SportsCenter> query, SportCenterSearchObject search)
    {
        if (!string.IsNullOrEmpty(search.Name))
        {
            query = query.Where(x => x.Name.ToLower().StartsWith(search.Name));
        }
        return query;
    }
}