using System.ComponentModel.DataAnnotations;

namespace WeNeed1.Model.Payloads
{
    public class CommentRequestDto
    {
        [Required]
        [MaxLength(500, ErrorMessage = "Comment cannot exceed 500 characters.")]
        public string? Content { get; set; }

        [Required(ErrorMessage = "Comment ID is required")]
        public int? MatchId { get; set; }
    }
}