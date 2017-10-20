using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace TournamentApp.Models {
    public class Tournament {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int EntryFee { get; set; }

        public ICollection<Team> Teams { get; set; } = new Collection<Team>();
        public ICollection<Matchup> Matchups { get; set; } = new Collection<Matchup>();
        public ICollection<Prize> Prizes { get; set; } = new Collection<Prize>();
    }
}