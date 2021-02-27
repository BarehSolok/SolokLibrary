using Rocket.Unturned.Player;
using Rocket.API;

namespace AtomicLibrary.Player.Funcs
{
    public class HasPermission
    {
        public bool hasPermission(UnturnedPlayer player, string permission) => player.HasPermission(permission);
    }
}
