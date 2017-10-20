using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentApp.Models {
    public class Team {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<Player> Players { get; set; } = new Collection<Player>();
        [InverseProperty("Teams")]
        public ICollection<Matchup> Matchups { get; set; } = new Collection<Matchup>();
        public ICollection<Tournament> Tournaments { get; set; } = new Collection<Tournament>();
    }
}