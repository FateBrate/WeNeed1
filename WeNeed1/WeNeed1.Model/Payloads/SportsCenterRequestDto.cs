namespace WeNeed1.Model.Payloads;

public class SportsCenterRequestDto
{
    public string? Name { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? Description { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public byte[]? Image { get; set; }

}