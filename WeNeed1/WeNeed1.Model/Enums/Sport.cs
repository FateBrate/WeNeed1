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
        [EnumMember(Value="FOOTBALL")]
        FOOTBALL = 1,

        [EnumMember(Value ="BASKETBALL")]
        BASKETBALL = 2
       
    }
}
