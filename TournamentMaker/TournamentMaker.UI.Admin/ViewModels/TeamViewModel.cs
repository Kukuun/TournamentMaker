using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TournamentMaker.Models;
using TournamentMaker.UI.Admin.Interfaces;

namespace TournamentMaker.UI.Admin.ViewModels {
    public class TeamViewModel : ITeamViewModel {
        private ITeamLookupDataService _teamLookupDataService;

        public ObservableCollection<LookupItem> Teams { get; }

        public TeamViewModel(ITeamLookupDataService teamLookupDataService) {
            _teamLookupDataService = teamLookupDataService;

            Teams = new ObservableCollection<LookupItem>();
            //FillTeams();
        }

        public async Task LoadAsync() {
            var lookup = await _teamLookupDataService.GetTeamLookupAsync();

            Teams.Clear();

            foreach (var item in lookup) {
                Teams.Add(item);
            }
        }

        //private bool HasTeam() {
        //    return Teams.Count > 0 ? true : false;
        //}

        //private void FillTeams() {
        //    Teams.Add(new LookupItem {
        //        Id = 1,
        //        DisplayMember = "Team troels"
        //    });
        //    Teams.Add(new LookupItem {
        //        Id = 2,
        //        DisplayMember = "Team brian"
        //    });
        //    Teams.Add(new LookupItem {
        //        Id = 3,
        //        DisplayMember = "Team poul"
        //    });
        //}
    }
}
