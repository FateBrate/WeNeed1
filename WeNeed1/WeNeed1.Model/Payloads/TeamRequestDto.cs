using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeNeed1.Model.Enums;

namespace WeNeed1.Model.Payloads
{
    public class TeamRequestDto
    {
        public string? Name { get; set; }
        public Sport? Sport { get; set; }
        public string? Description { get; set; }
        public bool? IsPublic { get; set; } 
    }
}
