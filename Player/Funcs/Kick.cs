using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.Unturned.Player;
using System.Threading.Tasks;

namespace AtomicLibrary.Player.Funcs
{
    public class Kick
    {
        public void kick(UnturnedPlayer player, string reason) => player.Kick(reason);
    }
}
