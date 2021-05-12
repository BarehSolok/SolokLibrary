using Rocket.Unturned.Player;

namespace SolokLibrary.Player.Functions
{
    public static class BrowserRequestFunction
    {
        public static void BrowserRequest(UnturnedPlayer player, string msg, string url) => player.Player.sendBrowserRequest(msg, url);
    }
}
