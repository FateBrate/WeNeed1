using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WeNeed1.Model.Enums;

namespace WeNeed1.Model.Requests
{
    public class UserRequestDto
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? UserName { get; set; }
        public string? PhoneNumber { get; set; }
        public Role? Role { get; set; }


        [Compare("ConfirmPassword", ErrorMessage = "Passwords do not match")]
        public string? Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string? ConfirmPassword { get; set; }

    }
}
