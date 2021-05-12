using Rocket.Unturned.Player;

namespace SolokLibrary.Player.Functions
{
    public static class KickFunction
    {
        public static void Kick(UnturnedPlayer player, string reason)
        {
            player.Kick(reason);
        }

        public static void Kick(UnturnedPlayer player)
        {
            player.Kick("You have been kicked from server.");
        }
    }
}
