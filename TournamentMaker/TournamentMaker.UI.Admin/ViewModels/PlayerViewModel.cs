using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TournamentMaker.Models;
using TournamentMaker.UI.Admin.Data;

namespace TournamentMaker.UI.Admin.ViewModels {
    public class PlayerViewModel : IPlayerViewModel {
        private IPlayerLookupDataService _playerLookupDataService;
        
        public ObservableCollection<LookupItem> Players { get; set; }

        public PlayerViewModel(IPlayerLookupDataService playerLookupDataService) {
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
