using Rocket.Unturned.Player;
using SDG.Unturned;
using UnityEngine;

namespace AtomicLibrary.Player.Funcs
{
    public class Damage
    {
        public void damage(UnturnedPlayer player, byte amount)
        {
            Vector3 direction = new Vector3(player.Position.x, player.Position.y);
            player.Damage(amount, direction, EDeathCause.KILL, ELimb.SPINE, player.CSteamID);
        }
    }
}
