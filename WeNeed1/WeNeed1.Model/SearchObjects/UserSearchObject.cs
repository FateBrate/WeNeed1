using WeNeed1.Model.Enums;
using WeNeed1.Model.SearchObjects;

namespace WeNeed1.Model.SearchOBjects
{
    public class UserSearchObject: BaseSearchObject
    {
        public string? FullName { get; set; } 
        public int? ExcludeTeamId { get; set; }
        public Role? Role { get; set; }
    }
}
