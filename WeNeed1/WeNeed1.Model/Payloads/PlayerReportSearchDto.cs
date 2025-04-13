using WeNeed1.Model.Enums;

namespace WeNeed1.Model.Payloads;

public class PlayerReportSearchDto
{
    public int UserId { get; set; }
    public ReportType ReportType { get; set; }
    public int? Month { get; set; }
    public int Year { get; set; }
}