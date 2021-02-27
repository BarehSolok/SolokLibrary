using Rocket.Unturned.Player;
using UnityEngine;
using SDG.Unturned;

namespace AtomicLibrary.Raycasts
{
    public class AtomicRaycasts
    {
        public static UnturnedPlayer lookedPlayer;
        public static BarricadeDrop lookedBarricadeDrop;
        public static BarricadeRegion lookedBarricadeRegion;
        public static StructureDrop lookedStructureDrop;
        public static StructureRegion lookedStructureRegion;
        public static void playerRaycast(UnturnedPlayer player, float distance)
        {
            RaycastHit raycastHit;
            if(Physics.Raycast(player.Player.look.aim.position, player.Player.look.aim.forward, out raycastHit, distance, RayMasks.PLAYER_INTERACT))
            {
                Transform _Transform = raycastHit.transform;
                var lookPlayer = UnturnedPlayer.FromPlayer(_Transform.GetComponent<PlayerInteract>().player);
                lookedPlayer = lookPlayer;
            }
        }
        public static void barricadeRaycast(UnturnedPlayer player, float distance)
        {
            RaycastHit raycastHit;
            if(Physics.Raycast(player.Player.look.aim.position, player.Player.look.aim.forward, out raycastHit, distance, RayMasks.BARRICADE_INTERACT))
            {
                Transform transform = raycastHit.transform;
                if(BarricadeManager.tryGetInfo(transform, out byte x, out byte y, out ushort plant, out ushort index, out BarricadeRegion region, out BarricadeDrop drop))
                {
                    lookedBarricadeDrop = drop;
                    lookedBarricadeRegion = region;
                }
            }
        }
        public static void structureRaycast(UnturnedPlayer player, float distance)
        {
            RaycastHit raycastHit;
            if(Physics.Raycast(player.Player.look.aim.position, player.Player.look.aim.forward, out raycastHit, distance, RayMasks.STRUCTURE_INTERACT))
            {
                Transform transform = raycastHit.transform;
                if(StructureManager.tryGetInfo(transform, out byte x, out byte y, out ushort index, out StructureRegion region, out StructureDrop drop))
                {
                    lookedStructureDrop = drop;
                    lookedStructureRegion = region;
                }
            }
        }
    }
}
