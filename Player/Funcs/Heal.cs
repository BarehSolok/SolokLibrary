using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Unturned.Player;
using SDG.Unturned;

namespace AtomicLibrary.Player.Funcs
{
    public class Heal
    {
        public void heal(UnturnedPlayer player, byte heal) => player.Heal(heal);
    }
}
