using Rocket.Unturned.Player;
using SDG.Unturned;

namespace SolokLibrary.Player.Functions
{
    public static class ReleaseFunction
    {
        public static void Release(UnturnedPlayer player) => player.Player.animator.sendGesture(EPlayerGesture.ARREST_STOP, true);
    }
}
