using System;
using System.Collections.Generic;

namespace WeNeed1.Service.Database;

public partial class Comment
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string? Content { get; set; }

    public DateTime Created { get; set; }

    public int MatchId { get; set; }

    public virtual Match Match { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
