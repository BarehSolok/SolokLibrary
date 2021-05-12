using Rocket.Unturned.Player;
using UnityEngine;

namespace SolokLibrary.Player.Functions
{
    public static class SetMarkerFunction
    {
        public static void SetMarker(UnturnedPlayer player, Vector3 vector3) =>
            player.Player.quests.sendSetMarker(true, vector3);

        public static void SetMarker(UnturnedPlayer player, Vector3 vector3, string markerText) 
        {
            player.Player.quests.replicateSetMarker(true, vector3, markerText);
        }
    }
}
