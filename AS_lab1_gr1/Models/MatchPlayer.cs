namespace AS_lab1_gr1.Models
{
    public class MatchPlayer
    {
        public int Id { get; set; }

        public ICollection<MatchEvent> MatchEvents { get; set; }

        public Player Player { get; set; }
        public int PlayerId { get; set; }

        public Position Position { get; set; }
        public int PositionId { get; set; }

        public Match Match { get; set; }
        public int MatchId { get; set; }
    }
}
