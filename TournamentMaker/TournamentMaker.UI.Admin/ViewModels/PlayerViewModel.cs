using System.Threading.Tasks;
using TournamentMaker.UI.Admin.Interfaces;

namespace TournamentMaker.UI.Admin.ViewModels {
    public class PlayerViewModel : IPlayerViewModel {
        public IPlayerNavigationViewModel PlayerNavigationViewModel { get; }

        public PlayerViewModel(IPlayerNavigationViewModel playerNavigationViewModel) {
            PlayerNavigationViewModel = playerNavigationViewModel;
        }

        public async Task LoadAsync() {
            await PlayerNavigationViewModel.LoadAsync();
        }
    }
}
