using Rocket.Unturned.Player;
using SDG.Unturned;

namespace AtomicLibrary.Player.Funcs
{
    public class RemoveFromVehicle
    {
        public static void removeFromVehicle(UnturnedPlayer player) => VehicleManager.forceRemovePlayer(player.CurrentVehicle, player.CSteamID);
    }
}
