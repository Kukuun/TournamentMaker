using System.ComponentModel.DataAnnotations;

namespace TournamentApp.Models {
    public class PlayerPhoneNumber {
        public int Id { get; set; }

        [Phone]
        [Required]
        public string Number { get; set; }

        public int PlayerId { get; set; }

        public Player Player { get; set; }
    }
}