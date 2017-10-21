using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Tournament.UI.Admin.Interfaces;
using TournamentApp.DataAccess;
using TournamentApp.Models;

namespace Tournament.UI.Admin.Data {
    public class PlayerDataService : IPlayerDataService {
        private Func<TournamentDbContext> _contextCreator;

        public async Task<List<Player>> GetAllAsync() {
            using (var ctx = _contextCreator()) {
                return await ctx.Players.AsNoTracking().ToListAsync();
            }
        }

        public PlayerDataService(Func<TournamentDbContext> contextCreator) {
            _contextCreator = contextCreator;
        }
    }
}