using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace TournamentApp.Models {
    public class Tournament {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int EntryFee { get; set; }

        public ICollection<Team> Teams { get; set; }
        public ICollection<MatchUp> MatchUps { get; set; }
        public ICollection<Prize> Prizes { get; set; }

        public Tournament() {
            Teams = new Collection<Team>();
            MatchUps = new Collection<MatchUp>();
            Prizes = new Collection<Prize>();
        }
    }
}