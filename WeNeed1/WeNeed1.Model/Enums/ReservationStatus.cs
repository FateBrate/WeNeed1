using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WeNeed1.Model.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ReservationStatus
{
    [EnumMember(Value = "CREATED")]
    CREATED = 1,

    [EnumMember(Value = "PAYED")]
    PAYED = 2,

    [EnumMember(Value = "CANCELLED")]
    CANCELLED = 3,

    [EnumMember(Value = "FINISHED")]
    FINISHED = 4
}