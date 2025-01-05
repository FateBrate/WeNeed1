using System.ComponentModel.DataAnnotations;

namespace WeNeed1.Model.Payloads;

public class ReviewRequestDto
{
    [Required]
    [MaxLength(500)]
    public string? Content { get; set; }
    
    [Range(1, 5)]
    public decimal Rating { get; set; }
}