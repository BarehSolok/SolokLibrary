using Rocket.API;
using Rocket.Unturned.Player;

namespace SolokLibrary.Player.Functions
{
    public static class HasPermissionFunction
    {
        public static bool HasPermission(UnturnedPlayer player, string permission) => player.HasPermission(permission);
    }
}
