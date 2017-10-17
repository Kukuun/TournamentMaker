using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace TournamentApp.Models {
    public class Player {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string Alias { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        public ICollection<PlayerPhoneNumber> PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string Mail { get; set; }

        public Player() {
            PhoneNumber = new Collection<PlayerPhoneNumber>();
        }
    }
}