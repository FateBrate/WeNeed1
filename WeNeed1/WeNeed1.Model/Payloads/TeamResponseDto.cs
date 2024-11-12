using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeNeed1.Model.Enums;

namespace WeNeed1.Model.Payloads
{
    public class TeamResponseDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Sport? Sport { get; set; }   
        public string? Description { get; set; }
        public bool? IsPublic { get; set; }
        public string? JoinCode { get; set; }

        public int CaptainId { get; set; }
        public User? Captain { get; set; }  
        
        public List<User> TeamMembers { get; set; } = new List<User>();

    }
}
