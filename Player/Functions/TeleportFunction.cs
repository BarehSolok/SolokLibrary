using Rocket.Unturned.Player;
using UnityEngine;

namespace SolokLibrary.Player.Functions
{
    public static class TeleportFunction
    {
        public static void Teleport(UnturnedPlayer player, Vector3 vector3) => player.Player.sendTeleport(vector3, player.Player.look.angle);
        public static void TeleportToBed(UnturnedPlayer player) => player.Player.teleportToBed();
        public static void TeleportToPlayer(UnturnedPlayer player, UnturnedPlayer target) => player.Player.teleportToPlayer(target.Player);
        public static void TeleportToRandomSpawnPoint(UnturnedPlayer player) => player.Player.teleportToRandomSpawnPoint();
        public static void TeleportUnsafe(UnturnedPlayer player, Vector3 vector3) => player.Player.teleportToLocationUnsafe(vector3, player.Player.look.yaw);
    }
}
