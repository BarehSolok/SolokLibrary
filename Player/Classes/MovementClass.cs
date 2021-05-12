using Rocket.Unturned.Player;
using SolokLibrary.Player.Functions;
using Steamworks;
using UnityEngine;

namespace SolokLibrary.Player.Classes
{
    public class MovementClass
    {
        // PVT. FIELDS
        private readonly CSteamID _steamID;
        
        // CONSTRUCTOR
        public MovementClass(CSteamID steamID)
        {
            _steamID = steamID;
        }
        
        // PROPS
        public bool BypassUndergroundCheck => UnturnedPlayer.FromCSteamID(_steamID).Player.movement.bypassUndergroundWhitelist;
        public float Gravity
        {
            get => UnturnedPlayer.FromCSteamID(_steamID).Player.movement.pluginGravityMultiplier;
            set => UnturnedPlayer.FromCSteamID(_steamID).Player.movement.sendPluginGravityMultiplier(value);
        } 
        public bool InSnow => UnturnedPlayer.FromCSteamID(_steamID).Player.movement.inSnow;
        public bool IsGrounded => UnturnedPlayer.FromCSteamID(_steamID).Player.movement.isGrounded;
        public bool IsJump => UnturnedPlayer.FromCSteamID(_steamID).Player.movement.jump;
        public bool IsMoving => UnturnedPlayer.FromCSteamID(_steamID).Player.movement.isMoving;
        public bool IsRadiated => UnturnedPlayer.FromCSteamID(_steamID).Player.movement.isRadiated;
        public bool IsSafe => UnturnedPlayer.FromCSteamID(_steamID).Player.movement.isSafe;
        public float JumpHeight
        {
            get => UnturnedPlayer.FromCSteamID(_steamID).Player.movement.pluginJumpMultiplier;
            set => UnturnedPlayer.FromCSteamID(_steamID).Player.movement.sendPluginJumpMultiplier(value);
        } 
        public float Speed
        {
            get => UnturnedPlayer.FromCSteamID(_steamID).Player.movement.pluginSpeedMultiplier;
            set => UnturnedPlayer.FromCSteamID(_steamID).Player.movement.sendPluginSpeedMultiplier(value);
        } 
        
        // METHODS
        public void Teleport(Vector3 vector3) => TeleportFunction.Teleport(UnturnedPlayer.FromCSteamID(_steamID), vector3);
        public void TeleportUnsafe(Vector3 vector3) => TeleportFunction.TeleportUnsafe(UnturnedPlayer.FromCSteamID(_steamID), vector3);
        public void TeleportToBed() => TeleportFunction.TeleportToBed(UnturnedPlayer.FromCSteamID(_steamID));
        public void TeleportToPlayer(UnturnedPlayer target) => TeleportFunction.TeleportToPlayer(UnturnedPlayer.FromCSteamID(_steamID), target);
        public void TeleportToRandomSpawnPoint() => TeleportFunction.TeleportToRandomSpawnPoint(UnturnedPlayer.FromCSteamID(_steamID));
    }
}