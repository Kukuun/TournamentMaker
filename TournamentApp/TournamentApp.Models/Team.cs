using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace TournamentApp.Models {
    public class Team {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<Player> Players { get; set; }

        public Team() {
            Players = new Collection<Player>();
        }
    }
}