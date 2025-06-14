using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeNeed1.Model.Enums;

namespace WeNeed1.Model.Payloads
{
    public class TeamRequestDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Team name is required")]
        public string? Name { get; set; }

        public byte[]? TeamPicture { get; set; }
        public Sport? Sport { get; set; }
        public string? Description { get; set; }
        public bool? IsPublic { get; set; } 

        public string? City { get; set; }
    }
}
