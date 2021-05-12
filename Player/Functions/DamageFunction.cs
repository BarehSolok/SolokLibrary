using Rocket.Unturned.Player;
using SDG.Unturned;
using UnityEngine;

namespace SolokLibrary.Player.Functions
{
    public static class DamageFunction
    {
        public static void Damage(UnturnedPlayer player, byte amount)
        {
            var direction = new Vector3(player.Position.x, player.Position.y);
            player.Damage(amount, direction, EDeathCause.KILL, ELimb.SPINE, player.CSteamID);
        }
    }
}
