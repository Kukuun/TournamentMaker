using System.Data.Entity;

namespace Tournament.DataAccess {
    public class TournamentDbContext : DbContext {
        public TournamentDbContext() : base("TournamentDb") {
        }
    }
}