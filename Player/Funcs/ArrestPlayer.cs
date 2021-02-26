using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Unturned;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Rocket.Unturned.Events;

namespace AtomicLibrary.Player.Funcs
{
    public class ArrestPlayer
    {
        public void arrestPlayer(UnturnedPlayer player)
        {
                player.Player.animator.tellGesture(player.CSteamID, (byte)EPlayerGesture.ARREST_START);
        }
    }
}
