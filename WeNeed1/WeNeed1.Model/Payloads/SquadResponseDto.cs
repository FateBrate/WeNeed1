using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeNeed1.Model.Payloads
{
    public class SquadResponseDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int TeamId { get; set; }

        public  TeamResponseDto? Team { get; set; }

        public ICollection<User>? Users { get; } = new List<User>();
    }
}
