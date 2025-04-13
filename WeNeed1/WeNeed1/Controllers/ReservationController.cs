using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service;

namespace WeNeed1.Controllers;
[ApiController]
public class ReservationController : BaseCRUDController<ReservationResponseDto, ReservationSearchObject, ReservationRequestDto, ReservationRequestDto>
{
    private readonly IReservationService _reservationService;

    public ReservationController(ILogger<BaseController<ReservationResponseDto, ReservationSearchObject>> logger,
        IReservationService reservationService) : base(logger, reservationService)
    {
        _reservationService = reservationService;
    }
    
    [HttpGet("available-slots")]
    public IActionResult GetAvailableSlots(int sportsFieldId, DateTime date)
    {
        var availableSlots = _reservationService.GetAvailableSlots(sportsFieldId, date);
        return Ok(availableSlots);
    }
    
    [HttpPatch("{id}/cancel")]
    [Authorize (Roles = "MANAGER")]
    public async Task<IActionResult> CancelReservation(int id, [FromBody] string? cancellationReason)
    {
        var updatedReservation = await _reservationService.CancelReservation(id, cancellationReason);
        return Ok(updatedReservation);
    }

    [HttpPatch("{id}/finish")]
    [Authorize (Roles = "MANAGER")]
    public async Task<IActionResult> FinishReservation(int id)
    {
        var updatedReservation = await _reservationService.FinishReservation(id);
        return Ok(updatedReservation);
    }
    
    [HttpPatch("{id}/pay")]
    [Authorize (Roles = "PLAYER")]
    public async Task<IActionResult> PayReservation(int id)
    {
        var updatedReservation = await _reservationService.PayReservation(id);
        return Ok(updatedReservation);
    }
    
    [HttpGet("report")]
    [Authorize(Roles = "MANAGER")]
    public async Task<IActionResult> GetManagerReport()
    {
        var report = await _reservationService.GetReportForManagerAsync();
        return Ok(report);
    }
    
    [HttpPost("report/player")]
    [Authorize(Roles = "MANAGER")]
    public async Task<IActionResult> GetPlayerReport([FromBody] PlayerReportSearchDto search)
    {
        var result = await _reservationService.GetPlayerReport(search);
        return Ok(result);
    }
}