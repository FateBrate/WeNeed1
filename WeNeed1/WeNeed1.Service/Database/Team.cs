using System;
using System.Collections.Generic;

namespace WeNeed1.Service.Database;

public partial class Team
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Sport { get; set; }

    public int CaptainId { get; set; }

    public string JoinCode { get; set; } = null!;

    public virtual User Captain { get; set; } = null!;

    public virtual ICollection<Match> Matches { get; } = new List<Match>();

    public virtual ICollection<Squad> Squads { get; } = new List<Squad>();
}
