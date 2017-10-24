using System.Threading.Tasks;

namespace TournamentMaker.UI.Admin.Interfaces {
    public interface IPlayerDetailViewModel {
        Task LoadAsync(int playerId);
    }
}