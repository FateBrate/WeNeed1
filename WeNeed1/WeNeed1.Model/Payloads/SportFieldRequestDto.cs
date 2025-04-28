using System.ComponentModel.DataAnnotations;

namespace WeNeed1.Model.Payloads;

public class SportFieldRequestDto
{   
    [MaxLength(500)]
    public string? Name { get; set; }
    
    public string? SportType { get; set; }
    
    public decimal? PricePerHour { get; set; }
    
    [MaxLength(500)]
    public string? Description { get; set; }
    
    [Required]
    public int SportsCenterId { get; set; }
    
    public byte[]? Image { get; set; }
    
}