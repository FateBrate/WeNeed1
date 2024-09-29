using System;
using System.Collections.Generic;

namespace WeNeed1.Service.Database;

public partial class Squad
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int TeamId { get; set; }

    public virtual Team? Team { get; set; }

    public virtual ICollection<User>? Users { get; } = new List<User>();
}
