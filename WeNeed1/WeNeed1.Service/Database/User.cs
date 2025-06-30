using WeNeed1.Model.Enums;

namespace WeNeed1.Service.Database;

public partial class User
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? PasswordHash { get; set; }

    public string? PasswordSalt { get; set; }

    public string? UserName { get; set; }

    public Role? Role { get; set; }

    public string? PhoneNumber { get; set; }

    public byte[]? ProfilePicture { get; set; }

    public double? Rating { get; set; }

    public virtual ICollection<Comment>? Comments { get; } = new List<Comment>();

    public virtual ICollection<Reservation>? Reservations { get; } = new List<Reservation>();

    public virtual ICollection<UserTeam> UserTeams { get; set; } = new List<UserTeam>();

    public virtual ICollection<Squad>? Squads { get; } = new List<Squad>();
    
    public virtual SportsCenter? SportsCenter { get; set; }

    public virtual ICollection<UserSport> UserSports { get; set; } = new List<UserSport>();

}
