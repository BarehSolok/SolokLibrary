using System.Linq;
using Rocket.Core;
using Rocket.Unturned.Player;

namespace SolokLibrary.Player.Functions
{
    public static class GroupFunction
    {
        public static void AddGroup(UnturnedPlayer player, string groupID) => R.Permissions.AddPlayerToGroup(groupID, player);
        public static bool HasGroup(UnturnedPlayer player, string groupID) => R.Permissions.GetGroups(player, true).Any(group => @group.Id == groupID);
        public static void RemoveGroup(UnturnedPlayer player, string groupID) => R.Permissions.RemovePlayerFromGroup(groupID, player);
    }
}
