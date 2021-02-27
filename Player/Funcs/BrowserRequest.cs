using Rocket.Unturned.Player;

namespace AtomicLibrary.Player.Funcs
{
    public class BrowserRequest
    {
        public static void browserRequest(UnturnedPlayer player, string msg, string url) => player.Player.sendBrowserRequest(msg, url);
    }
}
