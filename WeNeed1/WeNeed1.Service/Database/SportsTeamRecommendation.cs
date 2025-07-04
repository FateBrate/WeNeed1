namespace WeNeed1.Service.Database
{
    public partial class SportsTeamRecommendation
    {
        public int Id { get; set; }

        public int BaseTeamId { get; set; }
        public int RecommendedTeamId { get; set; }
        public float Score { get; set; }

        public virtual Team? BaseTeam { get; set; }
        public virtual Team? RecommendedTeam { get; set; }
    }
}
