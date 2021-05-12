using Rocket.Unturned.Player;
using SDG.Unturned;
using SolokLibrary.Player.Functions;
using Steamworks;
using UnityEngine;

namespace SolokLibrary.Player.Classes
{
    public class LookClass
    {
        // PVT. FIELDS
        private readonly CSteamID _steamID;
        
        // CONSTRUCTOR
        public LookClass(CSteamID steamID)
        {
            _steamID = steamID;
        }
        
        // PROPS
        public bool CanUseBuildMode => UnturnedPlayer.FromCSteamID(_steamID).Player.look.canUseWorkzone;
        public bool CanUseFreecam => UnturnedPlayer.FromCSteamID(_steamID).Player.look.canUseFreecam;
        public bool CanUseSpecStats => UnturnedPlayer.FromCSteamID(_steamID).Player.look.canUseSpecStats;
        public Vector3 EyesPosition => UnturnedPlayer.FromCSteamID(_steamID).Player.look.getEyesPosition();
        public Vector3 EyesPositionWithoutLeaning => UnturnedPlayer.FromCSteamID(_steamID).Player.look.GetEyesPositionWithoutLeaning();
        public bool IsFocusingCam => UnturnedPlayer.FromCSteamID(_steamID).Player.look.isFocusing;
        public bool IsIgnoringInput => UnturnedPlayer.FromCSteamID(_steamID).Player.look.isIgnoringInput;
        public bool IsLockingCam => UnturnedPlayer.FromCSteamID(_steamID).Player.look.isLocking;
        public bool IsOrbitingCam => UnturnedPlayer.FromCSteamID(_steamID).Player.look.isOrbiting;
        public bool IsSmoothingCam => UnturnedPlayer.FromCSteamID(_steamID).Player.look.isSmoothing;
        public bool IsTrackingCam => UnturnedPlayer.FromCSteamID(_steamID).Player.look.isTracking;
        public bool IsUsingFreecam => UnturnedPlayer.FromCSteamID(_steamID).Player.look.isCam;
        public bool IsUsingScope => UnturnedPlayer.FromCSteamID(_steamID).Player.look.isScopeActive;
        public bool IsUsingSpecStats => UnturnedPlayer.FromCSteamID(_steamID).Player.look.areSpecStatsVisible;
        
        // METHODS
        public void DisableOverlay() => LookFunction.DisableOverlay(_steamID);
        public void DisableScope() => LookFunction.DisableScope(_steamID);
        public void DisableZoom() => LookFunction.DisableZoom(_steamID);
        public void EnableOverlay() => LookFunction.EnableOverlay(_steamID);
        public void EnableScope(float zoom, ELightingVision vision) => LookFunction.EnableScope(_steamID, zoom, vision);
        public void EnableZoom(float zoom) => LookFunction.EnableZoom(_steamID, zoom);
    }
}