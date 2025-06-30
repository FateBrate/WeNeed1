using WeNeed1.Model.Enums;

namespace WeNeed1.Service.Database
{
    public partial class UserSport
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public Sport Sport { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
