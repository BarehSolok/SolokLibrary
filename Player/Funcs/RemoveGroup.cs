using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Core;
using Rocket.Unturned.Player;

namespace AtomicLibrary.Player.Funcs
{
    public class RemoveGroup
    {
        public void removeGroup(UnturnedPlayer player, string groupID) => R.Permissions.RemovePlayerFromGroup(groupID, player);
    }
}
