using System.Threading.Tasks;

namespace TournamentMaker.UI.Admin.ViewModels {
    public interface IPlayerDetailViewModel {
        Task LoadAsync(int playerId);
    }
}