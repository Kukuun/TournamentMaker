using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TournamentApp.Models;

namespace TournamentApp.DataAccess {
    public class TournamentDbContext : DbContext {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Prize> Prizes { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Matchup> Matchups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}