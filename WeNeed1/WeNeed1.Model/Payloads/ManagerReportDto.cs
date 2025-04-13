namespace WeNeed1.Model.Payloads;

public class ManagerReportDto
{
    public string? UserName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int ReservationCount { get; set; }
    public decimal TotalAmount { get; set; }
    public List<ReservationResponseDto>? Reservations { get; set; }
}