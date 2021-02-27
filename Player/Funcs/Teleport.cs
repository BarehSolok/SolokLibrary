using Rocket.Unturned.Player;
using UnityEngine;

namespace AtomicLibrary.Player.Funcs
{
    public class Teleport
    {
        public static void teleport(UnturnedPlayer player, Vector3 vector3) => player.Player.sendTeleport(vector3, 1);
    }
}
