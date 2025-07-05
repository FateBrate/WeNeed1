namespace WeNeed1.Model.Payloads;

public class SportsCenterResponseDto
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? Description { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public byte[]? Image { get; set; }

}