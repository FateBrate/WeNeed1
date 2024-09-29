using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WeNeed1.Model.Enums;

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

    }
}
