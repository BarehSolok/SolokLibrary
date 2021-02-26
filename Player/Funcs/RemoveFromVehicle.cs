using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;
using Rocket.Unturned.Player;
using System.Threading.Tasks;
using SDG.Unturned;

namespace AtomicLibrary.Player.Funcs
{
    public class RemoveFromVehicle
    {
        public void removeFromVehicle(UnturnedPlayer player) => VehicleManager.forceRemovePlayer(player.CurrentVehicle, player.CSteamID);
    }
}
