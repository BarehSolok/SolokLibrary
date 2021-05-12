using SDG.Unturned;
using Rocket.Unturned.Player;

namespace SolokLibrary.Player.Properties
{
    public static class ArrestedPlayer
    {
        public static bool Arrested(UnturnedPlayer player)
        {
            return player.Player.animator.gesture == EPlayerGesture.ARREST_START;
        }
        public static bool Arrested(SPlayer player)
        {
            return player.Animator.Gesture == EPlayerGesture.ARREST_START;
        }
    }
}
