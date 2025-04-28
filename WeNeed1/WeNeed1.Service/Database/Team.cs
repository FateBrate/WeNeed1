using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WeNeed1.Model.Enums;

namespace WeNeed1.Service.Database;

public partial class Team
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public Sport? Sport { get; set; }

    public string? Description { get; set; }

    public bool? IsPublic { get; set; }

    public int? CaptainId { get; set; }
    [ForeignKey("CaptainId")]
    public virtual User? Captain { get; set; }
    public string? JoinCode { get; set; }

    public byte[]? TeamPicture { get; set; }


    public virtual ICollection<UserTeam> UserTeams { get; set; } = new List<UserTeam>();

    public virtual ICollection<Match>? Matches { get; } = new List<Match>();

    public virtual ICollection<Squad>? Squads { get; } = new List<Squad>();
}
