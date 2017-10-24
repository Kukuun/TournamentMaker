using System.Collections.Generic;
using System.Threading.Tasks;
using TournamentMaker.Models;

namespace TournamentMaker.UI.Admin.ViewModels {
    public interface ITeamViewModel {
        Task LoadAsync();
    }
}