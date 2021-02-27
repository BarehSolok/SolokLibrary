using Rocket.Unturned.Player;

namespace AtomicLibrary.Player.Funcs
{
    public class Kick
    {
        public static void kick(UnturnedPlayer player, string reason) => player.Kick(reason);
    }
}
