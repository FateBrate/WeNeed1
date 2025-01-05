namespace WeNeed1.Model.Payloads;

public class SportFieldResponseDto
{
    public int Id { get; set; }

    public string? Name { get; set; }
    
    public string? SportType { get; set; }
    
    public decimal PricePerHour { get; set; }
    
    public string? Description { get; set; }
    
    public int SportsCenterId { get; set; }
    
}