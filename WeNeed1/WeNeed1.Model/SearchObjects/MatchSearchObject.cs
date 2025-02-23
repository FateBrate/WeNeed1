using WeNeed1.Model.Enums;

namespace WeNeed1.Model.SearchObjects
{
    public class MatchSearchObject : BaseSearchObject
    {
        public int? TeamId { get; set; }
        public MatchStatus? Status { get; set; }
    }
}