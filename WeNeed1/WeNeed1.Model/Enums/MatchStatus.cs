using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeNeed1.Model.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MatchStatus
    {
        [EnumMember(Value = "CREATED")]
        CREATED = 1,

        [EnumMember(Value = "FINISHED")]
        FINISHED = 2,

        [EnumMember(Value = "CANCELLED")]
        CANCELLED = 3

    }
}
