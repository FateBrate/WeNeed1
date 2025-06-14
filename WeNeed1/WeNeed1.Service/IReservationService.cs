using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;

namespace WeNeed1.Service;

public interface IReservationService: ICRUDService<ReservationResponseDto, ReservationSearchObject, ReservationRequestDto, ReservationRequestDto>
{
    List<TimeSpan> GetAvailableSlots(int sportsFieldId, DateTime date);
    
    Task<ReservationResponseDto> CancelReservation(int id, string? cancellationReason);
    
    Task<ReservationResponseDto> FinishReservation(int id);
    
    Task<ReservationResponseDto> PayReservation(int id, string transactionId);

    Task<ManagerReportDto> GetReportForManagerAsync();

    Task<PlayerReportResponseDto> GetPlayerReport(PlayerReportSearchDto reportSearchDto);
    
    Task<List<UserResponseDto>> GetUsersWithReservationsForManagerAsync();
}