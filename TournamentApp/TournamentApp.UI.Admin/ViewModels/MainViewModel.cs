using System.Collections.ObjectModel;
using TournamentApp.Models;
using TournamentApp.UI.Admin.ViewModels;

namespace Tournament.UI.Admin.ViewModels {
    public class MainViewModel : ViewModelBase {
        public ObservableCollection<Player> Players { get; set; }

        public MainViewModel() {
            Players = new ObservableCollection<Player>();
        }

        public void Load() {
            var friends = :
        }
    }
}