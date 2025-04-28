namespace WeNeed1.Model.Payloads;

public class SportsCenterRequestDto
{
    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Description { get; set; }
    
    public TimeSpan StartTime { get; set; }
    
    public TimeSpan EndTime { get; set; } 
    
    public byte[]? Image { get; set; }

}