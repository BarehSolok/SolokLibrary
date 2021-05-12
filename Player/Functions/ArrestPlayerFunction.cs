using Rocket.Unturned.Player;
using SDG.Unturned;

namespace SolokLibrary.Player.Functions
{
    public static class ArrestPlayerFunction
    {
        public static void ArrestPlayer(UnturnedPlayer player)
        {
                //player.Player.animator.tellGesture(player.CSteamID, (byte)EPlayerGesture.ARREST_START);
                player.Player.animator.sendGesture(EPlayerGesture.ARREST_START, true);
        }
    }
}
