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
    public async Task<IActionResult> CancelReservation(int id, [FromBody] string? cancellationReason)
    {
        var updatedReservation = await _reservationService.CancelReservation(id, cancellationReason);
        return Ok(updatedReservation);
    }

    [HttpPatch("{id}/finish")]
    public async Task<IActionResult> FinishReservation(int id)
    {
        var updatedReservation = await _reservationService.FinishReservation(id);
        return Ok(updatedReservation);
    }
}