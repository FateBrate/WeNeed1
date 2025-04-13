using System.Runtime.Serialization;

namespace WeNeed1.Model.Enums;

public enum ReportType
{
    [EnumMember(Value = "MONTHLY")]
    MONTHLY = 1,
    
    [EnumMember(Value = "YEARLY")]
    YEARLY = 2
}