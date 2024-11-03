using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeNeed1.Model.Payloads
{
    public class SquadRequestDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Squad name is required")]
        public string? Name { get; set; }
        public int? TeamId { get; set; }
    }
}
