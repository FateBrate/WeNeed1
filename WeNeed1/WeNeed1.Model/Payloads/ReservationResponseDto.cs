using WeNeed1.Model.Enums;

namespace WeNeed1.Model.Payloads;

public class ReservationResponseDto
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public decimal TotalPrice { get; set; }
    public int SportsFieldId { get; set; }
    public ReservationStatus Status { get; set; }
    public string? CancellationReason { get; set; }
    public SportFieldResponseDto? SportFieldResponseDto { get; set; }
}