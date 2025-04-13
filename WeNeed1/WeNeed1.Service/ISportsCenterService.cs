using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;

namespace WeNeed1.Service;

public interface ISportsCenterService : ICRUDService<SportsCenterResponseDto,BaseSearchObject,SportsCenterRequestDto,SportsCenterRequestDto>
{
    Task<SportsCenterResponseDto> GetMySportsCenterAsync();

}