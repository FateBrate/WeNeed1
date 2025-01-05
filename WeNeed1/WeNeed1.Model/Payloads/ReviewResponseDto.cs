namespace WeNeed1.Model.Payloads;

public class ReviewResponseDto
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int SportsCenterId { get; set; }

    public string? Content { get; set; }

    public decimal Rating { get; set; }

    public DateTime Created { get; set; }
}