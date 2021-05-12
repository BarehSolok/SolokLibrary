using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;

namespace SolokLibrary.Player.Classes
{
    public class SkillsClass
    {
        // PVT. FIELDS
        private readonly CSteamID _steamID;
        
        // CONSTRUCTOR
        public SkillsClass(CSteamID steamID)
        {
            _steamID = steamID;
        }
        
        // PROPS
        public EPlayerBoost SkillBoost => UnturnedPlayer.FromCSteamID(_steamID).Player.skills.boost;
    }
}