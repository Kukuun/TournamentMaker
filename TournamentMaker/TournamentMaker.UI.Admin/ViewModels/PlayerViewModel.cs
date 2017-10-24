using System.Threading.Tasks;
using TournamentMaker.UI.Admin.Interfaces;

namespace TournamentMaker.UI.Admin.ViewModels {
    public class PlayerViewModel : IPlayerViewModel {
        public IPlayerNavigationViewModel PlayerNavigationViewModel { get; }
        public IPlayerDetailViewModel PlayerDetailViewModel { get; }

        public PlayerViewModel(IPlayerNavigationViewModel playerNavigationViewModel, IPlayerDetailViewModel playerDetailViewModel) {
            PlayerNavigationViewModel = playerNavigationViewModel;
            PlayerDetailViewModel = playerDetailViewModel;
        }

        public async Task LoadAsync() {
            await PlayerNavigationViewModel.LoadAsync();
        }
    }
}
