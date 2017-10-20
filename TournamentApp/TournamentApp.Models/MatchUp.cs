using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentApp.Models {
    public class Matchup {
        public int Id { get; set; }
        
        public int? WinnerId { get; set; }

        public Team Winner { get; set; }

        public Tournament Tournament { get; set; }

        [Required]
        public ICollection<Team> Teams { get; set; } = new Collection<Team>();
    }
}