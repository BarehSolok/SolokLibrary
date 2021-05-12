using Rocket.Unturned.Player;
using SolokLibrary.Player.Functions;
using Steamworks;

namespace SolokLibrary.Player.Classes
{
    public class InventoryClass
    {
        // PVT. FIELDS
        private readonly CSteamID _steamID;
        
        // CONSTRUCTOR
        public InventoryClass(CSteamID steamID)
        {
            _steamID = steamID;
        }
        
        // PROPS
        public bool IsStoring => UnturnedPlayer.FromCSteamID(_steamID).Player.inventory.isStoring;
        public bool IsStoringTrunk => UnturnedPlayer.FromCSteamID(_steamID).Player.inventory.isStorageTrunk;
        
        // METHODS
        public void GiveItem(ushort itemID) => ItemFunction.GiveItem(UnturnedPlayer.FromCSteamID(_steamID), itemID, 1);
        public void GiveItem(ushort itemID, byte amount) => ItemFunction.GiveItem(UnturnedPlayer.FromCSteamID(_steamID), itemID, amount);
        public void RemoveItem(ushort itemID) => ItemFunction.RemoveItem(UnturnedPlayer.FromCSteamID(_steamID), itemID);
    }
}