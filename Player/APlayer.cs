using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API;
using Rocket.Unturned.Player;
using Steamworks;
using SDG.Unturned;
using AtomicLibrary.Raycasts;

namespace AtomicLibrary.Player
{
    public class APlayer
    {
        static CSteamID steamID { get; set; }
        private Functions Functions = new Functions();
        private AtomicRaycasts Raycasts = new AtomicRaycasts();
        public void Convert(UnturnedPlayer player) => APlayer.steamID = player.CSteamID;

        public void Convert(IRocketPlayer RocketPlayer) => APlayer.steamID = ((UnturnedPlayer)RocketPlayer).CSteamID;
        public void addGroup(string groupID) => Functions.addGroup.addGroup(UnturnedPlayer.FromCSteamID(steamID), groupID);
        public void arrestPlayer() => Functions.arrestPlayer.arrestPlayer(UnturnedPlayer.FromCSteamID(steamID));
        public void browserRequest(string msg, string url) => Functions.browserRequest.browserRequest(UnturnedPlayer.FromCSteamID(steamID), msg, url);
        public void damage(byte amount) => Functions.damage.damage(UnturnedPlayer.FromCSteamID(steamID), amount);
        public void hasGroup(string groupID) => Functions.hasGroup.hasGroup(UnturnedPlayer.FromCSteamID(steamID), groupID);
        public void hasPermission(string permission) => Functions.hasPermission.hasPermission(UnturnedPlayer.FromCSteamID(steamID), permission);
        public void heal(byte amount) => Functions.heal.heal(UnturnedPlayer.FromCSteamID(steamID), amount);
        public void kick(string reason) => Functions.kick.kick(UnturnedPlayer.FromCSteamID(steamID), reason);
        public void kill() => Functions.kill.kill(UnturnedPlayer.FromCSteamID(steamID));
        public void maxSkills() => Functions.maxSkills.maxSkills(UnturnedPlayer.FromCSteamID(steamID));
        public void release() => Functions.release.release(UnturnedPlayer.FromCSteamID(steamID));
        public void removeFromVehicle() => Functions.removeFromVehicle.removeFromVehicle(UnturnedPlayer.FromCSteamID(steamID));
        public void removeGroup(string groupID) => Functions.removeGroup.removeGroup(UnturnedPlayer.FromCSteamID(steamID), groupID);
        public void setMarker(UnityEngine.Vector3 vector3) => Functions.setMarker.setMarker(UnturnedPlayer.FromCSteamID(steamID), vector3);
        public void sudo(string text) => Functions.sudo.sudo(UnturnedPlayer.FromCSteamID(steamID), text);
        public void teleport(UnityEngine.Vector3 vector3) => Functions.teleport.teleport(UnturnedPlayer.FromCSteamID(steamID), vector3);
        public UnturnedPlayer lookPlayer(float distance)
        {
            Raycasts.playerRaycast(UnturnedPlayer.FromCSteamID(steamID), distance);
            return Raycasts.lookedPlayer;
        }
        public BarricadeDrop lookBarricade(float distance)
        {
            Raycasts.barricadeRaycast(UnturnedPlayer.FromCSteamID(steamID), distance);
            return Raycasts.lookedBarricadeDrop;
        }
        public StructureDrop lookStructure(float distance)
        {
            Raycasts.structureRaycast(UnturnedPlayer.FromCSteamID(steamID), distance);
            return Raycasts.lookedStructureDrop;
        }
    }
}
