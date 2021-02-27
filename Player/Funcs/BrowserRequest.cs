using Rocket.Unturned.Player;

namespace AtomicLibrary.Player.Funcs
{
    public class BrowserRequest
    {
        public void browserRequest(UnturnedPlayer player, string msg, string url) => player.Player.sendBrowserRequest(msg, url);
    }
}
