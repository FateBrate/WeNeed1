namespace WeNeed1.Model.Payloads;

public class ManagerReportDto
{
    public int ReservationCount { get; set; }
    public decimal TotalAmount { get; set; }
    public List<ReservationResponseDto>? Reservations { get; set; }
}