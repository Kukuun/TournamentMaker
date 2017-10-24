using System.Threading.Tasks;
using TournamentMaker.Models;
using TournamentMaker.UI.Admin.Interfaces;

namespace TournamentMaker.UI.Admin.ViewModels {
    public class PlayerDetailViewModel : ViewModelBase, IPlayerDetailViewModel {
        private IPlayerDataService _playerDataService;
        private Player _player;

        public Player Player {
            get { return _player; }
            private set {
                _player = value;
                OnPropertyChanged();
            }
        }
        
        public PlayerDetailViewModel(IPlayerDataService playerDataService) {
            _playerDataService = playerDataService;
        }

        public async Task LoadAsync(int playerId) {
            Player = await _playerDataService.GetByIdAsync(playerId);
        }
    }
}
