using Rocket.Unturned.Player;

namespace AtomicLibrary.Player.Funcs
{
    public class Heal
    {
        public void heal(UnturnedPlayer player, byte heal) => player.Heal(heal);
    }
}
