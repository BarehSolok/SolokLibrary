using Rocket.Unturned.Player;
using SDG.Unturned;

namespace SolokLibrary.Player.Functions
{
    public static class RemoveFromVehicleFunction
    {
        public static void RemoveFromVehicle(UnturnedPlayer player) => VehicleManager.forceRemovePlayer(player.CurrentVehicle, player.CSteamID);
    }
}
