using System;
using System.Data.Entity;
using System.Threading.Tasks;
using TournamentMaker.DataAccess;
using TournamentMaker.Models;
using TournamentMaker.UI.Admin.Interfaces;

namespace TournamentMaker.UI.Admin.Data {
    public class PlayerDataService : IPlayerDataService {
        private Func<TournamentDbContext> _contextCreator;

        public PlayerDataService(Func<TournamentDbContext> contextCreator) {
            _contextCreator = contextCreator;
        }

        public async Task<Player> GetByIdAsync(int playerId) {
            using (var context = _contextCreator()) {
                return await context.Players.AsNoTracking().SingleAsync(p => p.Id == playerId);
            }
        }
    }
}
