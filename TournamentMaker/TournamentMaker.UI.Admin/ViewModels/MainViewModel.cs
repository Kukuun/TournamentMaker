using System.Threading.Tasks;
using TournamentMaker.UI.Admin.Interfaces;

namespace TournamentMaker.UI.Admin.ViewModels {
    public class MainViewModel : ViewModelBase {
        public IPlayerViewModel PlayerViewModel { get; }

        public MainViewModel(IPlayerViewModel playerViewModel) {
            PlayerViewModel = playerViewModel;
        }

        public async Task LoadAsync() {
            await PlayerViewModel.LoadAsync();
        }
    }
}