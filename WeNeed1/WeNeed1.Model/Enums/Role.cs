using System.Runtime.Serialization;
using System.Text.Json.Serialization;


namespace WeNeed1.Model.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Role
    {
        [EnumMember(Value = "MANAGER")]
        MANAGER = 1,

        [EnumMember(Value = "PLAYER")]
        PLAYER = 2
    }
}
