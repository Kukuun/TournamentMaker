namespace TournamentApp.Models {
    public class MatchUpEntry {
        public int Id { get; set; }

        public Team CompetingTeam { get; set; }

        public int? Score { get; set; }

        public MatchUp MatchUp { get; set; }
    }
}