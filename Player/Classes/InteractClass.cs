using Rocket.Unturned.Player;
using Steamworks;

namespace SolokLibrary.Player.Classes
{
    public class InteractClass
    {
        // PVT. FIELDS
        private readonly CSteamID _steamID;

        // CONSTRUCTOR
        public InteractClass(CSteamID steamID)
        {
            _steamID = steamID;
        }
        
        // PROPS
        public void SalvageTime(float newSalvageTime) => UnturnedPlayer.FromCSteamID(_steamID).Player.interact
            .sendSalvageTimeOverride(newSalvageTime);
    }
}