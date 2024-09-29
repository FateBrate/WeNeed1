using System;
using System.Collections.Generic;

namespace WeNeed1.Service.Database;

public partial class Match
{
    public int Id { get; set; }

    public int TeamId { get; set; }

    public DateTime MatchDate { get; set; }

    public string? Result { get; set; }

    public virtual ICollection<Comment>? Comments { get; } = new List<Comment>();

    public virtual Team? Team { get; set; }
}
