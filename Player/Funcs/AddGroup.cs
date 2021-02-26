using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Unturned.Player;
using Rocket.Core;

namespace AtomicLibrary.Player.Funcs
{
    public class AddGroup
    {
        public void addGroup(UnturnedPlayer player, string groupID) => R.Permissions.AddPlayerToGroup(groupID, player);
    }
}
