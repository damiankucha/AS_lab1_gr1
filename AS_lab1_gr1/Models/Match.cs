namespace AS_lab1_gr1.Models
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Stadium { get; set; }

        // Article
        public ICollection<Article> Articles { get; set; }

        // Home Team
        public Team HomeTeam { get; set; }
        public int HomeTeamId { get; set; }

        // Away Team
        public Team AwayTeam { get; set; }
        public int AwayTeamId { get; set; }

        // Match Event
        public ICollection<MatchEvent> MatchEvents { get; set; }

    }
}
