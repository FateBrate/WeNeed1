using WeNeed1.Model.Enums;
using WeNeed1.Model.Payloads;

namespace WeNeed1.Model
{
    public partial class User
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? UserName { get; set; }

        public Role? Role { get; set; }

        public string? PhoneNumber { get; set; }

        public byte[]? ProfilePicture { get; set; }
        
        public SportsCenterResponseDto? SportsCenter { get; set; }

    }
}
