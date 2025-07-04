namespace WeNeed1.Service.Database;

public partial class SportsCenter
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Description { get; set; }
    
    public TimeSpan StartTime { get; set; } = TimeSpan.FromHours(10);
    public TimeSpan EndTime { get; set; } = TimeSpan.FromHours(23);
    
    public virtual ICollection<Review> Reviews { get; } = new List<Review>();

    public virtual ICollection<SportsField> SportsFields { get; } = new List<SportsField>();
    
    public int? ManagerId { get; set; }
    
    public virtual User? Manager { get; set; }
    
    public byte[]? Image { get; set; }

    public virtual ICollection<SportsCenterRecommendation> BaseRecommendations { get; set; } = new List<SportsCenterRecommendation>();
    public virtual ICollection<SportsCenterRecommendation> RecommendedBy { get; set; } = new List<SportsCenterRecommendation>();
}
