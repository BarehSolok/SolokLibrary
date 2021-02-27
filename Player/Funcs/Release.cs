using SDG.Unturned;
using Rocket.Unturned.Player;

namespace AtomicLibrary.Player.Funcs
{
    public class Release
    {
        public void release(UnturnedPlayer player) => player.Player.animator.sendGesture(EPlayerGesture.ARREST_STOP, true);
    }
}
