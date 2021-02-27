using Rocket.Unturned.Player;
using UnityEngine;
using SDG.Unturned;

namespace AtomicLibrary.Player.Funcs
{
    public class Kill
    {
        public static void kill(UnturnedPlayer player)
        {
            Vector3 direction = new Vector3(player.Position.x, player.Position.y);
            player.Damage(255, direction, EDeathCause.KILL, ELimb.SPINE, player.CSteamID);

        }
    }
}
