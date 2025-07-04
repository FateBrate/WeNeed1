namespace WeNeed1.Service.Database
{
    public partial class UserSquad
    {
        public int UserId { get; set; }
        public int SquadId { get; set; }
        public virtual User? User { get; set; } 
        public virtual Squad? Squad { get; set; }
    }
}
