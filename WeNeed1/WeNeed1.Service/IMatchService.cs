using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;

namespace WeNeed1.Service;

public interface IMatchService: ICRUDService<MatchResponseDto,MatchSearchObject,MatchRequestDto,MatchRequestDto>
{
    
}