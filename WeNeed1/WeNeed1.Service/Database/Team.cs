﻿using System;
using System.Collections.Generic;
using WeNeed1.Model.Enums;

namespace WeNeed1.Service.Database;

public partial class Team
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public Sport? Sport { get; set; }

    public string? Description { get; set; }

    public bool? IsPublic { get; set; }

    public int CaptainId { get; set; }

    public string? JoinCode { get; set; }

    public virtual User? Captain { get; set; }

    public virtual ICollection<Match>? Matches { get; } = new List<Match>();

    public virtual ICollection<Squad>? Squads { get; } = new List<Squad>();
}
