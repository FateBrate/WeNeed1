using System.ComponentModel.DataAnnotations;
using WeNeed1.Model.Enums;

namespace WeNeed1.Model.Payloads
{
    public class MatchRequestDto
    {
        [Required (ErrorMessage = "TeamId is required")]
        public int? TeamId { get; set; }

        [Required(ErrorMessage = "Match date is required")]
        public DateTime? MatchDate { get; set; }

        public MatchStatus Status { get; set; }

        public string Result { get; set; }
    }
}
