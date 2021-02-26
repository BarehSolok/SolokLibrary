using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Unturned.Player;
using SDG.Unturned;

namespace AtomicLibrary.Player.Funcs
{
    public class Sudo
    {
        public void sudo(UnturnedPlayer player, string text) => ChatManager.instance.askChat(player.CSteamID, (byte)EChatMode.SAY, text);
    }
}
