using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Unturned.Player;

namespace AtomicLibrary.Player.Funcs
{
    public class BrowserRequest
    {
        public void browserRequest(UnturnedPlayer player, string msg, string url) => player.Player.sendBrowserRequest(msg, url);
    }
}
