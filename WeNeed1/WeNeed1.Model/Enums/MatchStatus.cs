﻿using System.Runtime.Serialization;
using System.Text.Json.Serialization;

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
