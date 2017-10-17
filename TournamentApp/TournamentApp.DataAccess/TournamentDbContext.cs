using System.Data.Entity;
using TournamentApp.Models;

namespace TournamentApp.DataAccess {
    public class TournamentDbContext : DbContext {
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerPhoneNumber> PlayerPhoneNumbers { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Prize> Prizes { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<MatchUp> MatchUps { get; set; }
    }
}