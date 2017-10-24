using Prism.Events;
using System.Threading.Tasks;
using TournamentMaker.Models;
using TournamentMaker.UI.Admin.Events;
using TournamentMaker.UI.Admin.Interfaces;

namespace TournamentMaker.UI.Admin.ViewModels {
    public class PlayerDetailViewModel : ViewModelBase, IPlayerDetailViewModel {
        private IEventAggregator _eventAggregator;
        private IPlayerDataService _playerDataService;
        private Player _player;

        public Player Player {
            get { return _player; }
            private set {
                _player = value;
                OnPropertyChanged();
            }
        }
        
        public PlayerDetailViewModel(IEventAggregator eventAggregator, IPlayerDataService playerDataService) {
            _eventAggregator = eventAggregator;
            _playerDataService = playerDataService;

            _eventAggregator.GetEvent<OpenPlayerDetailViewEvent>().Subscribe(OnOpenPlayerDetailView);
        }

        private async void OnOpenPlayerDetailView(int playerId) {
            await LoadAsync(playerId);
        }

        public async Task LoadAsync(int playerId) {
            Player = await _playerDataService.GetByIdAsync(playerId);
        }
    }
}
