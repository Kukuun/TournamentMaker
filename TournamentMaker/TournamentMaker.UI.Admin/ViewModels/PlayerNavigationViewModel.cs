using Prism.Events;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TournamentMaker.Models;
using TournamentMaker.UI.Admin.Events;
using TournamentMaker.UI.Admin.Interfaces;

namespace TournamentMaker.UI.Admin.ViewModels {
    public class PlayerNavigationViewModel : ViewModelBase, IPlayerNavigationViewModel {
        private IEventAggregator _eventAggregator;
        private IPlayerLookupDataService _playerLookupDataService;
        private LookupItem _selectedPlayer;

        public LookupItem SelectedPlayer {
            get { return _selectedPlayer; }
            set {
                _selectedPlayer = value;
                OnPropertyChanged();

                if (_selectedPlayer != null) {
                    _eventAggregator.GetEvent<OpenPlayerDetailViewEvent>().Publish(_selectedPlayer.Id);
                }
            }
        }
        
        public ObservableCollection<LookupItem> Players { get; }

        public PlayerNavigationViewModel(IEventAggregator eventAggregator, IPlayerLookupDataService playerLookupDataService) {
            _eventAggregator = eventAggregator;
            _playerLookupDataService = playerLookupDataService;

            Players = new ObservableCollection<LookupItem>();
        }

        public async Task LoadAsync() {
            var lookup = await _playerLookupDataService.GetFriendLookupAsync();

            Players.Clear();

            foreach (var item in lookup) {
                Players.Add(item);
            }
        }
    }
}
