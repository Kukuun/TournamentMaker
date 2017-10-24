﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TournamentMaker.Models;

namespace TournamentMaker.UI.Admin.Data {
    public interface IPlayerDataService {
        Task<Player> GetByIdAsync(int playerId);
    }
}