using AutoMapper;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service.Database;

namespace WeNeed1.Service.Impl;

public class SportsFieldService : BaseCRUDService<SportFieldResponseDto, SportsField, SportFieldSearchObject, SportFieldRequestDto, SportFieldRequestDto>, ISportsFieldService
{
    public SportsFieldService(WeNeed1Context context, IMapper mapper) : base(context, mapper)
    {
    }

    public override IQueryable<SportsField> AddFilter(IQueryable<SportsField> query, SportFieldSearchObject? search = null)
    {
        if (search?.SportsCenterId.HasValue == true)
        {
            query = query.Where(x => x.SportsCenterId == search.SportsCenterId);
        }

        if (!string.IsNullOrEmpty(search.Name))
        {
            query = query.Where(x => x.Name.ToLower().Contains(search.Name.ToLower()));
        }
        return query;
    }
}