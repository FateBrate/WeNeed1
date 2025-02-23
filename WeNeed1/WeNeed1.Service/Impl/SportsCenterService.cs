using AutoMapper;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service.Database;

namespace WeNeed1.Service.Impl;

public class SportsCenterService : BaseCRUDService<SportsCenterResponseDto, SportsCenter, BaseSearchObject, SportsCenterRequestDto, SportsCenterRequestDto>, ISportsCenterService
{
    public SportsCenterService(WeNeed1Context context, IMapper mapper) : base(context, mapper)
    {

    }
}