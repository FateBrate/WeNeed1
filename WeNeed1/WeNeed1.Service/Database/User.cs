using System;
using System.Collections.Generic;

namespace WeNeed1.Service.Database;

public partial class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string PasswordSalt { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public byte[]? ProfilePicture { get; set; }

    public double? Rating { get; set; }

    public virtual ICollection<Comment> Comments { get; } = new List<Comment>();

    public virtual ICollection<Reservation> Reservations { get; } = new List<Reservation>();

    public virtual ICollection<Team> Teams { get; } = new List<Team>();

    public virtual ICollection<Squad> Squads { get; } = new List<Squad>();
}
