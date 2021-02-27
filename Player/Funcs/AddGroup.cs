using Rocket.Unturned.Player;
using Rocket.Core;

namespace AtomicLibrary.Player.Funcs
{
    public class AddGroup
    {
        public static void addGroup(UnturnedPlayer player, string groupID) => R.Permissions.AddPlayerToGroup(groupID, player);
    }
}
