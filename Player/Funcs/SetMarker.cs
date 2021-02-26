using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;
using Rocket.Unturned.Player;
using System.Threading.Tasks;
using UnityEngine;

namespace AtomicLibrary.Player.Funcs
{
    public class SetMarker
    {
        public void setMarker(UnturnedPlayer player, Vector3 vector3) => player.Player.quests.askSetMarker(player.CSteamID, true, vector3);
    }
}
