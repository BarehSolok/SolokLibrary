using System.Linq;
using Rocket.Unturned.Player;
using Rocket.Core;

namespace AtomicLibrary.Player.Funcs
{
    public class HasGroup
    {
        public static bool hasGroup(UnturnedPlayer player, string groupID) => R.Permissions.GetGroups(player, true).Any(group => group.Id == groupID);
    }
}
