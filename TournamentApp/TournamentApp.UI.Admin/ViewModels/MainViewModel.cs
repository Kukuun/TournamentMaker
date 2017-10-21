using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Tournament.UI.Admin.Interfaces;
using TournamentApp.Models;

namespace Tournament.UI.Admin.ViewModels {
    public class MainViewModel : ViewModelBase {
        private IPlayerDataService _playerDataService;
        private Player _selectedPlayer;

        public Player SelectedPlayer {
            get { return _selectedPlayer; }
            set {
                _selectedPlayer = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Player> Players { get; set; }

        public MainViewModel(IPlayerDataService playerDataService) {
            _playerDataService = playerDataService;

            Players = new ObservableCollection<Player>();
        }

        public async Task LoadAsync() {
            var players = await _playerDataService.GetAllAsync();

            Players.Clear();

            foreach (var player in players) {
                Players.Add(player);
            }
        }
    }
}