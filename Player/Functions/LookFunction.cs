using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;

namespace SolokLibrary.Player.Functions
{
    public static class LookFunction
    {
        public static void DisableOverlay(CSteamID steamID)
        {
            UnturnedPlayer.FromCSteamID(steamID).Player.look.disableOverlay();
        }
        public static void DisableScope(CSteamID steamID)
        {
            UnturnedPlayer.FromCSteamID(steamID).Player.look.disableScope();
        }
        public static void DisableZoom(CSteamID steamID)
        {
            UnturnedPlayer.FromCSteamID(steamID).Player.look.disableZoom();
        }
        public static void EnableZoom(CSteamID steamID, float zoom)
        {
            UnturnedPlayer.FromCSteamID(steamID).Player.look.enableZoom(zoom);
        }
        public static void EnableScope(CSteamID steamID, float zoom, ELightingVision vision)
        {
            UnturnedPlayer.FromCSteamID(steamID).Player.look.enableScope(zoom, vision);
        }
        public static void EnableOverlay(CSteamID steamID)
        {
            UnturnedPlayer.FromCSteamID(steamID).Player.look.enableOverlay();
        }
    }
}