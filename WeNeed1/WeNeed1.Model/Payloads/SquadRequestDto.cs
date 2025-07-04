using System.ComponentModel.DataAnnotations;

namespace WeNeed1.Model.Payloads
{
    public class SquadRequestDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Squad name is required")]
        public string? Name { get; set; }
        public int? TeamId { get; set; }
    }
}
