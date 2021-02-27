using Rocket.Unturned.Player;

namespace AtomicLibrary.Player.Funcs
{
    public class Kick
    {
        public void kick(UnturnedPlayer player, string reason) => player.Kick(reason);
    }
}
