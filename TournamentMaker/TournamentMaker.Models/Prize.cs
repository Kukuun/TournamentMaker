using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace TournamentMaker.Models {
    public class Prize {
        public int Id { get; set; }

        [Required]
        public string PlacementName { get; set; }

        [Required]
        public int PlacementNumber { get; set; }

        [Required]
        public decimal PrizeAmount { get; set; }

        public string Trophy { get; set; }

        public ICollection<Tournament> Tournaments { get; set; } = new Collection<Tournament>();
    }
}
