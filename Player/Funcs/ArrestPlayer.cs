using Rocket.Unturned.Player;
using SDG.Unturned;

namespace AtomicLibrary.Player.Funcs
{
    public class ArrestPlayer
    {
        public static void arrestPlayer(UnturnedPlayer player)
        {
                player.Player.animator.tellGesture(player.CSteamID, (byte)EPlayerGesture.ARREST_START);
        }
    }
}
