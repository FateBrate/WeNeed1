using WeNeed1.Model.Enums;

namespace WeNeed1.Model.Payloads;

public class MatchResponseDto
{
    public int Id { get; set; }
    public int TeamId { get; set; }
    public DateTime MatchDate { get; set; }
    public string Result { get; set; }
    public MatchStatus Status { get; set; }
}