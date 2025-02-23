namespace WeNeed1.Model.Payloads
{
    public class CommentResponseDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public int MatchId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}