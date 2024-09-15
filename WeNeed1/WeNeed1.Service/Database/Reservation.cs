using System;
using System.Collections.Generic;

namespace WeNeed1.Service.Database;

public partial class Reservation
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int SportsFieldId { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public decimal TotalPrice { get; set; }

    public virtual SportsField SportsField { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
