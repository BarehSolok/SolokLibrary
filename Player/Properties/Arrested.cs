using SDG.Unturned;
using Rocket.Unturned.Player;

namespace AtomicLibrary.Player.Properties
{
    public class Arrested
    {
        public bool arrested(UnturnedPlayer player)
        {
            if (player.Player.animator.gesture == EPlayerGesture.ARREST_START)
                return true;
            else
                return false;
        }
    }
}
