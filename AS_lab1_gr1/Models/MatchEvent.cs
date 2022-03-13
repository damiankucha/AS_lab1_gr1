namespace AS_lab1_gr1.Models
{
    public class MatchEvent
    {
        public int Id { get; set; }
        public int Minute { get; set; }

        public Match Match { get; set; }
        public int MatchId { get; set; }

        public EventType EventType { get; set; }
        public int EventTypeId { get; set; }

        public MatchPlayer? matchPlayer { get; set; }
        public int? MatchPlayerId { get; set; }
    }
}
