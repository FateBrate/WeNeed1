using WeNeed1.Model.Enums;

namespace WeNeed1.Model.SearchObjects;

public class ReservationSearchObject : BaseSearchObject
{
    public int? SportsCenterId { get; set; }
    public int? SportsFieldId { get; set; }
    
    public ReservationStatus? Status { get; set; }
}