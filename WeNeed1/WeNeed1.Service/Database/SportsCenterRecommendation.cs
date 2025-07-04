namespace WeNeed1.Service.Database
{
    public partial class SportsCenterRecommendation
    {
        public int Id { get; set; }

        public int BaseSportsCenterId { get; set; }
        public int RecommendedSportsCenterId { get; set; }
        public float Score { get; set; }

        public virtual SportsCenter? BaseSportsCenter { get; set; }
        public virtual SportsCenter? RecommendedSportsCenter { get; set; }
    }
}
