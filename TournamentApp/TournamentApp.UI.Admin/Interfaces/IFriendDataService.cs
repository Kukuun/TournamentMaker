using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentApp.Models;

namespace Tournament.UI.Admin.Interfaces {
    public interface IFriendDataService {
        IEnumerable<Player> GetAll();
    }
}
