using Rocket.Core;
using Rocket.Unturned.Player;

namespace AtomicLibrary.Player.Funcs
{
    public class RemoveGroup
    {
        public static void removeGroup(UnturnedPlayer player, string groupID) => R.Permissions.RemovePlayerFromGroup(groupID, player);
    }
}
