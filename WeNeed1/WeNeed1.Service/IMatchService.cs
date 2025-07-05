using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;

namespace WeNeed1.Service;

public interface IMatchService: ICRUDService<MatchResponseDto,MatchSearchObject,MatchRequestDto,MatchRequestDto>
{
    Task SetAttendance(int matchId, int userId, bool isAttending);

    Task<int> GetPlayedMatchCountForCurrentUser();
    Task<LastMatchSummaryDto?> GetLastMatchSummaryForCurrentUser();
}