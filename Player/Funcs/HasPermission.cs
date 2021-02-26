using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Unturned.Player;
using Rocket.API;

namespace AtomicLibrary.Player.Funcs
{
    public class HasPermission
    {
        public bool hasPermission(UnturnedPlayer player, string permission) => player.HasPermission(permission);
    }
}
