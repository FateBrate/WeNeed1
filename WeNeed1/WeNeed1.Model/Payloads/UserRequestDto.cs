using System.ComponentModel.DataAnnotations;
using WeNeed1.Model.Enums;

namespace WeNeed1.Model.Payloads
{
    public class UserRequestDto
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? UserName { get; set; }
        
        public string? PhoneNumber { get; set; }
        
        public byte[]? ProfilePicture { get; set; }
        
        public Role? Role { get; set; }
        
        [Compare("ConfirmPassword", ErrorMessage = "Passwords do not match")]
        public string? Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string? ConfirmPassword { get; set; }

    }
}
