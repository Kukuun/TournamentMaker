using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace TournamentApp.Models {
    public class MatchUp {
        public int Id { get; set; }

        public Team Winner { get; set; }

        public Tournament Tournament { get; set; }

        [Required]
        public ICollection<Team> CompetingTeams { get; set; }

        public MatchUp() {
            CompetingTeams = new Collection<Team>();
        }
    }
}