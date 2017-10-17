using System.ComponentModel.DataAnnotations;

namespace TournamentApp.Models {
    public class Prize {
        public int Id { get; set; }

        [Required]
        public string placementName { get; set; }

        [Required]
        public int placementNumber { get; set; }

        [Required]
        public decimal prizeAmount { get; set; }
    }
}