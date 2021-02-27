using Rocket.Unturned.Player;
using UnityEngine;

namespace AtomicLibrary.Player.Funcs
{
    public class SetMarker
    {
        public static void setMarker(UnturnedPlayer player, Vector3 vector3) => player.Player.quests.askSetMarker(player.CSteamID, true, vector3);
    }
}
