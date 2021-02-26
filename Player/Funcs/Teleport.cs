using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;
using Rocket.Unturned.Player;
using UnityEngine;
using System.Threading.Tasks;

namespace AtomicLibrary.Player.Funcs
{
    public class Teleport
    {
        public void teleport(UnturnedPlayer player, Vector3 vector3) => player.Player.sendTeleport(vector3, 1);
    }
}
