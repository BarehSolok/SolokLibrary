using Rocket.Unturned.Player;
using SDG.Unturned;
using UnityEngine;

namespace SolokLibrary.Player.Functions
{
    public static class RaycastFunction
    {
        public static void PlayerRaycast(UnturnedPlayer player, float distance, out UnturnedPlayer lookPlayer)
        {
            lookPlayer = null;
            if (!Physics.Raycast(player.Player.look.aim.position, player.Player.look.aim.forward, out var raycastHit,
                distance, RayMasks.PLAYER_INTERACT)) return;
            var transform = raycastHit.transform;
            lookPlayer = UnturnedPlayer.FromPlayer(transform.GetComponent<PlayerInteract>().player);
        }
        public static void BarricadeRaycast(UnturnedPlayer player, float distance, out BarricadeDrop lookBarricadeDrop, out BarricadeRegion lookBarricadeRegion)
        {
            lookBarricadeDrop = null;
            lookBarricadeRegion = null;
            if (!Physics.Raycast(player.Player.look.aim.position, player.Player.look.aim.forward, out var raycastHit,
                distance, RayMasks.BARRICADE_INTERACT)) return;
            var transform = raycastHit.transform;
            if (!BarricadeManager.tryGetInfo(transform, out _, out _, out _, out _,
                out var region, out var drop)) return;
            lookBarricadeDrop = drop;
            lookBarricadeRegion = region;
        }

        public static void StructureRaycast(UnturnedPlayer player, float distance, out StructureDrop lookStructureDrop, out StructureRegion lookStructureRegion)
        {
            lookStructureDrop = null;
            lookStructureRegion = null;
            if (!Physics.Raycast(player.Player.look.aim.position, player.Player.look.aim.forward, out var raycastHit,
                distance, RayMasks.STRUCTURE_INTERACT)) return;
            var transform = raycastHit.transform;
            if (!StructureManager.tryGetInfo(transform, out _, out _, out _, out var region,
                out var drop)) return;
            lookStructureDrop = drop;
            lookStructureRegion = region;
        }
    }
}
