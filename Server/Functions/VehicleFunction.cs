using SDG.Unturned;
using Steamworks;

namespace SolokLibrary.Server.Functions
{
    public static class VehicleFunction
    {
        public static void LockVehicle(InteractableVehicle vehicle, CSteamID owner, CSteamID group)
        {
            vehicle.tellLocked(owner, group, true);
        }
        public static void UnlockVehicle(InteractableVehicle vehicle)
        {
            vehicle.tellLocked(CSteamID.Nil, CSteamID.Nil, false);
        }
    }
}