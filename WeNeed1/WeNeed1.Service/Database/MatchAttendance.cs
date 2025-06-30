
namespace WeNeed1.Service.Database
{
    public partial class MatchAttendance
    {
        public int MatchId { get; set; }
        public int UserId { get; set; }
        public bool IsAttending { get; set; }

        public Match Match { get; set; }
        public User User { get; set; }
    }
}
