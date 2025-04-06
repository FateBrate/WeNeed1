using System;
using System.Collections.Generic;

namespace WeNeed1.Service.Database;

public partial class SportsField
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? SportType { get; set; }

    public string? Description { get; set; }

    public int Capacity { get; set; }

    public decimal PricePerHour { get; set; }

    public int SportsCenterId { get; set; }

    public virtual ICollection<Reservation>? Reservations { get; } = new List<Reservation>();

    public virtual SportsCenter? SportsCenter { get; set; }
    
}
