namespace WeNeed1.Service.Database;

public partial class UserTeam
{
    public int UserId { get; set; }
    public virtual User User { get; set; }

    public int TeamId { get; set; }
    public virtual Team Team { get; set; }

    public bool IsCaptain { get; set; }  
}
