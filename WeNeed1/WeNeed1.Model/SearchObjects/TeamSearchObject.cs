using WeNeed1.Model.Enums;

namespace WeNeed1.Model.SearchObjects
{
    public class TeamSearchObject :BaseSearchObject
    {
        public Sport? Sport { get; set; }
        public string? City { get; set; }
        public string? Name { get; set; }
        public bool? NotMember { get; set; }
        public int? UserId { get; set; }
        
        public bool? IsPublic { get; set; } 
        
        public string? JoinCode { get; set; } 
    }
}
