using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;

namespace SolokLibrary.Player.Classes
{
    public class AnimatorClass
    {
        // PVT. FIELDS
        private readonly CSteamID _steamID;
        
        // CONSTRUCTOR
        public AnimatorClass(CSteamID steamID)
        {
            _steamID = steamID;
        }
        
        // PROPS
        public EPlayerGesture Gesture
        {
            get => UnturnedPlayer.FromCSteamID(_steamID).Player.animator.gesture;
            set => UnturnedPlayer.FromCSteamID(_steamID).Player.animator.sendGesture(value, true);
        }
    }
}