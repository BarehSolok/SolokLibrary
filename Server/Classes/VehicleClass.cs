using SDG.Unturned;
using SolokLibrary.Server.Functions;
using Steamworks;

namespace SolokLibrary.Server.Classes
{
    public class VehicleClass
    {
        // FIELD
        public VehicleClass Instance;
        
        // CONSTRUCTOR
        public VehicleClass()
        {
            Instance = this;
        }
        
        // METHODS
        public static void LockVehicle(InteractableVehicle vehicle, CSteamID owner, CSteamID group) => VehicleFunction.LockVehicle(vehicle, owner, group);
        public static void UnlockVehicle(InteractableVehicle vehicle) => VehicleFunction.UnlockVehicle(vehicle);
    }
}