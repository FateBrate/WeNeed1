using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeNeed1.Model.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]

    public enum Sport
    {
        [EnumMember(Value = "FOOTBALL")]
        FOOTBALL = 1,

        [EnumMember(Value = "BASKETBALL")]
        BASKETBALL = 2,
        
        [EnumMember(Value = "FUTSAL")]
        FUTSAL = 3,

        [EnumMember(Value = "VOLLEYBALL")]
        VOLLEYBALL = 4,

        [EnumMember(Value = "BEACH_VOLLEYBALL")]
        BEACH_VOLLEYBALL = 5,

        [EnumMember(Value = "MINI_FOOTBALL")]
        MINI_FOOTBALL = 6,

        [EnumMember(Value = "HANDBALL")]
        HANDBALL = 7,
        
        [EnumMember(Value = "TENNIS")]
        TENNIS = 8
        
    }
}
