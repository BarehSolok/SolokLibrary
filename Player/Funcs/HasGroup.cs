using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API;
using Rocket.Unturned.Player;
using Rocket.Core;

namespace AtomicLibrary.Player.Funcs
{
    public class HasGroup
    {
        public bool hasGroup(UnturnedPlayer player, string groupID) => R.Permissions.GetGroups(player, true).Any(group => group.Id == groupID);
    }
}
