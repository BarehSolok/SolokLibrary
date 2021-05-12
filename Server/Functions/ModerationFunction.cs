using Rocket.Unturned.Player;
using Steamworks;

namespace SolokLibrary.Server.Functions
{
    public static class ModerationFunction
    {
        public static void Ban(CSteamID steamID, string reason, uint duration) => UnturnedPlayer.FromCSteamID(steamID).Ban(reason, duration);
    }
}