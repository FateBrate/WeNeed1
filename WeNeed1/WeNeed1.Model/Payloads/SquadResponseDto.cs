namespace WeNeed1.Model.Payloads
{
    public class SquadResponseDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int TeamId { get; set; }

        public  TeamResponseDto? Team { get; set; }

        public ICollection<User>? UserSquads { get; } = new List<User>();
    }
}
