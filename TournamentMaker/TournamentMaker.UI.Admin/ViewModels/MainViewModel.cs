using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TournamentMaker.Models;
using TournamentMaker.UI.Admin.Data;

namespace TournamentMaker.UI.Admin.ViewModels {
    public class MainViewModel : ViewModelBase {
        public IPlayerViewModel PlayerViewModel { get; set; }

        public ObservableCollection<Player> Players { get; set; }

        public MainViewModel(IPlayerViewModel playerViewModel) {
            PlayerViewModel = playerViewModel;
        }

        public async Task LoadAsync() {
            await PlayerViewModel.LoadAsync();
        }
    }
}