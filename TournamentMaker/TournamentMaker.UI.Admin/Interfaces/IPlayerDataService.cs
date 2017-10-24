using System.Threading.Tasks;
using TournamentMaker.Models;

namespace TournamentMaker.UI.Admin.Interfaces {
    public interface IPlayerDataService {
        Task<Player> GetByIdAsync(int playerId);
    }
}