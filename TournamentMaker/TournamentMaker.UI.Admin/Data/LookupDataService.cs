using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TournamentMaker.DataAccess;
using TournamentMaker.Models;
using TournamentMaker.UI.Admin.Interfaces;

namespace TournamentMaker.UI.Admin.Data {
    public class LookupDataService : IPlayerLookupDataService, ITeamLookupDataService {
        private Func<TournamentDbContext> _contextCreator;

        public LookupDataService(Func<TournamentDbContext> contextCreator) {
            _contextCreator = contextCreator;
        }

        public async Task<IEnumerable<LookupItem>> GetFriendLookupAsync() {
            using (var context = _contextCreator()) {
                return await context.Players.AsNoTracking().Select(p => new LookupItem {
                    Id = p.Id,
                    DisplayMember = p.FirstName + " \"" + p.Alias + "\" " + p.LastName
                }).ToListAsync();
            }
        }

        public async Task<IEnumerable<LookupItem>> GetTeamLookupAsync() {
            using (var context = _contextCreator()) {
                return await context.Teams.AsNoTracking().Select(t => new LookupItem {
                    Id = t.Id,
                    DisplayMember = t.Name
                }).ToListAsync();
            }
        }
    }
}
