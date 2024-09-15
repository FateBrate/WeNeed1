using System;
using System.Collections.Generic;

namespace WeNeed1.Service.Database;

public partial class SportsCenter
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Review> Reviews { get; } = new List<Review>();

    public virtual ICollection<SportsField> SportsFields { get; } = new List<SportsField>();
}
