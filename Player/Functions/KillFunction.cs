using Rocket.Unturned.Player;
using SDG.Unturned;

namespace SolokLibrary.Player.Functions
{
    public static class KillFunction
    {
        public static void Kill(UnturnedPlayer player)
        {
            player.Damage(byte.MaxValue, player.Position, EDeathCause.KILL, ELimb.SPINE, player.CSteamID);
        }
    }
}
